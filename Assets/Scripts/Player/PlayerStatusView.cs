using UniRx;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Player
{
    public class PlayerStatusView : MonoBehaviour
    {
        public ReactiveProperty<int> selectStatus = new ReactiveProperty<int>(0);
        [SerializeField] private GameObject fuda;
        [SerializeField] private Image black;

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
            black.DOFade(0.0f, 0.2f);
        }

        //選択のUIを元に戻す
        private void OpenUI()
        {
            fuda.transform.DOLocalMoveY(1.0f, 0.2f);
            black.DOFade(0.5f, 0.2f);
        }
    
    }

}
