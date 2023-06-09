using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class BattleView : MonoBehaviour
{
    public ReactiveProperty<bool> act = new ReactiveProperty<bool>(false);
    //王様の札
    [SerializeField] private GameObject kingsFuda;
    //左下に出る選んだ自分の手
    [SerializeField] private Sprite[] selectStatus;
    //王様の立ち絵
    [SerializeField] private Sprite[] kingStand;
    //王様の持つ札
    [SerializeField] private Sprite[] kingStatus;
    //数字の画像
    [SerializeField] private Sprite[] nums;
    //左下の手の欄
    [SerializeField] private Image select;
    //あなたと書かれたribbon
    [SerializeField] private Image you;
    //勝利数を示す右上のboard
    [SerializeField] private Image winBoard;
    //勝利数のboardの中の数字
    [SerializeField] private Image wins;
    //王様のオブジェクトの画像
    [SerializeField] private SpriteRenderer kingObj;
    
    //結果を表示するメソッド
    public void DisplayResult(int player, int king, int result, int winNum)
    {
        act.Value = true;
        //UniRxで時間差で表示するように
        var kingSubject = new Subject<int>();
        var winSubject = new Subject<int>();
        kingSubject
            .Delay(TimeSpan.FromSeconds(1))
            .Subscribe(num =>
                {
                    kingObj.sprite = kingStand[num];
                    kingsFuda.GetComponent<SpriteRenderer>().sprite = kingStatus[king];
                    kingsFuda.SetActive(true);
                }
            ).AddTo(this);
        winSubject
            .Delay(TimeSpan.FromSeconds(1))
            .Subscribe(num =>
                {
                    wins.sprite = nums[winNum];
                }
            ).AddTo(this);
            
        select.sprite = selectStatus[player];
        select.DOFade(1.0f, 0.5f);
        you.DOFade(1.0f, 0.3f);
        winBoard.DOFade(1.0f, 0.5f);
        wins.DOFade(1.0f, 0.5f);
        kingSubject.OnNext(result);
        winSubject.OnNext(winNum);
        CloseDisPlay();
    }

    //元に戻すメソッド(見えなくする)
    private void CloseDisPlay()
    {
        var closeSubject = new Subject<int>();
        var inactiveSubject = new Subject<int>();
        closeSubject
            .Delay(TimeSpan.FromSeconds(3.0f))
            .Subscribe(_ =>
                {
                    select.DOFade(0.0f, 0.5f);
                    you.DOFade(0.0f, 0.3f);
                    winBoard.DOFade(0.0f, 0.5f);
                    wins.DOFade(0.0f, 0.5f).OnComplete(() => act.Value = false);
                    kingObj.sprite = kingStand[3];
                    kingsFuda.SetActive(false);
                }
            ).AddTo(this);
        closeSubject.OnNext(0);
    }
    
}
