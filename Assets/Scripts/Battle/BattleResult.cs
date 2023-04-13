using King;
using Player;
using UniRx;
using UnityEngine;

public class BattleResult : MonoBehaviour
{
    private int turn = 0;

    private int win = 0;
    //王様の手
    [SerializeField] private KingStatusModel king;
    //プレイヤの手
    [SerializeField] private PlayerStatusModel player;
    //結果を表示するview
    [SerializeField] private BattleView _battleView;
    [SerializeField] private PlayerStatusController _playerStatusController;

    private void Start()
    {
        _battleView.act
            .Where(active => !active)
            .Subscribe(_ => _playerStatusController.FudaUI()).AddTo(this);
        turn = 0;
        win = 0;
    }

    //プレイヤの勝利の場合(player.ReturnStatus() - king.DecideStatus() + 3) % 3は2となるため1引いた数は1となり、それ以外は0になるようにする。
    private int winNum(int num)
    {
        if (num - 1 < 0)
        {
            return 0;
        }

        return num - 1;
    }

    //勝者を計算する。
    public void WinnerCheck()
    {
        //resultが0, 1, 2で出力され、それぞれプレイヤが引き分け、負け、勝利となる
        int result = 0;
        result = (player.ReturnStatus() - king.DecideStatus() + 3) % 3;
        win += winNum(result);
        _battleView.DisplayResult(player.ReturnStatus(), king.ReturnStatus(), result, win);
        turn++;
    }
}
