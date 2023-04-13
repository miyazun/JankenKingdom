using UnityEngine;


namespace Status
{
    public class JankenStatusModel : MonoBehaviour
    {
        //じゃんけんの出す手(0, 1, 2でグー, チョキ, パー)
        private int status = 0;
        
        //じゃんけんの出す手をセットする
        public void SetStatus(int decision)
        {
            status = decision;
        }

        //現在の手を返す
        public int ReturnStatus()
        {
            return status;
        }
    }
}
