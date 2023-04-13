using UniRx;
using UnityEngine;


namespace Status
{
    public class JankenStatusModel : MonoBehaviour
    {
        //じゃんけんの出す手(0, 1, 2でグー, チョキ, パー)
        public ReactiveProperty<int> status = new ReactiveProperty<int>(0);
        
        //じゃんけんの出す手をセットする
        public void SetStatus(int decision)
        {
            status.Value = decision;
        }

        //現在の手を返す
        public int ReturnStatus()
        {
            return status.Value;
        }
    }
}
