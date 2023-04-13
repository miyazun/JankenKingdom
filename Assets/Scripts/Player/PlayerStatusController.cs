using UnityEngine;
using UniRx;

namespace Player
{
    public class PlayerStatusController : MonoBehaviour
    {
        private PlayerStatusModel playerModel;

        private PlayerStatusView playerView;
        void Start()
        {
            playerView.selectStatus
                .Subscribe(num => playerModel.SetStatus(num)).AddTo(this);
        }

    }

}
