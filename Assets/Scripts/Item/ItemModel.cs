using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemModel : MonoBehaviour
{
    public int[] num = new int[5]{20, 20, 20, 20, 20};
    
    void Start () {
        DontDestroyOnLoad (this);
    }
    public void SetNum(int[] nums)
    {
        if (nums.Length == 0)
        {
            return;
        }
        num = nums;
    }
}
