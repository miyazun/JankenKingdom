using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Player
{
    public class PlayerStatusView : MonoBehaviour
    {
        public ReactiveProperty<int> selectStatus = new ReactiveProperty<int>(0);

        void Start()
        {
            selectStatus.Value = 0;
        }

        public void ChnageStatus(int select)
        {
            selectStatus.Value = select;
            Debug.Log("aa");
        }
    
    }

}
