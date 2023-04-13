using Status;


namespace King
{
    public class KingStatusModel : JankenStatusModel
    {

        //ランダムに出す手を決定するメドッド
        public int DecideStatus()
        {
            SetStatus(UnityEngine.Random.Range(0, 4));
            return ReturnStatus();
        }
    }
}

