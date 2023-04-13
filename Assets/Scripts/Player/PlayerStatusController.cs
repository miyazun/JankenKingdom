using UnityEngine;
using UniRx;

namespace Player
{
    public class PlayerStatusController : MonoBehaviour
    {
        [SerializeField]
        private PlayerStatusModel playerModel;

        [SerializeField]
        private PlayerStatusView playerView;
        void Start()
        {
            playerView.selectStatus
                .Subscribe(num => playerModel.SetStatus(num)).AddTo(this);
        }

    }

}
