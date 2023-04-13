using Status;


namespace King
{
    public class KingStatusModel : JankenStatusModel
    {
        private void Start()
        {
            DecideStatus();
        }

        //ランダムに出す手を決定するメドッド
        private void DecideStatus()
        {
            SetStatus(UnityEngine.Random.Range(0, 4));
        }
    }
}

