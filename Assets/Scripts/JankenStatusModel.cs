using UnityEngine;


namespace Status
{
    public class JankenStatusModel : MonoBehaviour
    {
        //じゃんけんの出す手(0, 1, 2でグー, チョキ, パー)
        private int status = 0;
        
        public void SetStatus(int decision)
        {
            status = decision;
        }

        public int ReturnStatus()
        {
            return status;
        }
    }
}
