using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
using UniRx;

public class ItemView : MonoBehaviour
{
    [SerializeField] private TMP_InputField[] itemNum;
    [SerializeField] private SceneChanger scene;

    public ReactiveProperty<int[]> num = new ReactiveProperty<int[]>(null);


    public void GetInputNum()
    {
        int i = 0;
        int all = 0;
        int[] sub = new int[5];
        for (i = 0; i < itemNum.Length; i++)
        {
            sub[i] = int.Parse(itemNum[i].text);
            all += sub[i];
        }

        //負の数がなく、総数が100の場合
        if (all == 100 && sub.All(j => j >= 0))
        {
            num.Value = sub;
            scene.ChnageScene("Title");
        }
    }
}
