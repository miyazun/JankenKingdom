using UnityEngine;
using UniRx;

namespace Player
{
    public class PlayerStatusController : MonoBehaviour
    {
        //プレイヤのデータ
        [SerializeField]
        private PlayerStatusModel playerModel;

        //プレイヤの見掛け
        [SerializeField]
        private PlayerStatusView playerView;
        void Start()
        {
            //viewの選択が変わったらmodelに移す
            playerView.selectStatus
                .Subscribe(num => playerModel.SetStatus(num)).AddTo(this);
        }

    }

}
