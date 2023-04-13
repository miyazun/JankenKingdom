using UnityEngine;
using UniRx;

namespace Player
{
    public class PlayerStatusController : MonoBehaviour
    {
        //プレイヤのデータ
        [SerializeField] private PlayerStatusModel playerModel;
        //プレイヤの見掛け
        [SerializeField] private PlayerStatusView playerView;
        //対戦結果のモデル
        [SerializeField] private BattleResult battleResult;
        
        void Start()
        {
            //viewの選択が変わったらmodelに移す
            playerView.selectStatus
                .Subscribe(num => playerModel.SetStatus(num)).AddTo(this);
            playerView.activeUI
                .Where(active => !active)
                .Subscribe(_ => battleResult.WinnerCheck()).AddTo(this);
        }

        public void FudaUI()
        {
            playerView.OpenUI();
        }

    }

}
