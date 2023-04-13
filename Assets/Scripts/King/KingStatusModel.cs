using Status;


namespace King
{
    public class KingStatusModel : JankenStatusModel
    {
        private void Start()
        {
            DecideStatus();
        }

        private void DecideStatus()
        {
            SetStatus(UnityEngine.Random.Range(0, 4));
        }
    }
}

