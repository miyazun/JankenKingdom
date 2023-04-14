using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemModel : MonoBehaviour
{
    public static int[] num = new int[5]{20, 20, 20, 20, 20};
    
    public void SetNum(int[] nums)
    {
        if (nums.Length == 0)
        {
            return;
        }
        num = nums;
    }
}
