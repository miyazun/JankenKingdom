using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

public class ItemView : MonoBehaviour
{
    [SerializeField] private TMP_InputField[] itemNum;
    [SerializeField] private SceneChanger scene;

    private int[] num = new int[5];


    public void GetInputNum()
    {
        int i = 0;
        int all = 0;
        for (i = 0; i < itemNum.Length; i++)
        {
            num[i] = int.Parse(itemNum[i].text);
            all += num[i];
        }

        //負の数がなく、総数が100の場合
        if (all == 100 && num.All(j => j >= 0))
        {
            scene.ChnageScene("Title");
        }
    }
}
