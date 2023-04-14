using UniRx;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Player
{
    public class PlayerStatusView : MonoBehaviour
    {
        public ReactiveProperty<int> selectStatus = new ReactiveProperty<int>(0);
        public ReactiveProperty<bool> activeUI = new ReactiveProperty<bool>(false);
        [SerializeField] private GameObject fuda;
        [SerializeField] private Image black;
        [SerializeField] private Image playNumtext;
        [SerializeField] private Image selecter;
        [SerializeField] private Sprite[] numText;

        void Start()
        {
            selectStatus.Value = 0;
        }
        
        //選択肢を変える
        public void ChnageStatus(int select)
        {
            //もしも2回同じものでクリックした場合は選択のUIを閉じる
            if (select == selectStatus.Value)
            {
                CloseUI();
            }
            selectStatus.Value = select;
        }

        //選択のUIを閉じる
        private void CloseUI()
        {
            fuda.transform.DOLocalMoveY(-3.5f, 0.2f);
            selecter.DOFade(0.0f, 0.2f);
            black.DOFade(0.0f, 0.2f);
            activeUI.Value = false;
        }

        //選択のUIを元に戻す
        public void OpenUI(int num)
        {
            playNumtext.sprite = numText[num];
            fuda.transform.DOLocalMoveY(1.0f, 0.2f);
            selecter.DOFade(1.0f, 0.1f);
            black.DOFade(0.5f, 0.2f);
            activeUI.Value = true;
        }
    
    }

}
