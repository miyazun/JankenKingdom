using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ResultView : MonoBehaviour
{
    [SerializeField] private GameObject board;
    [SerializeField] private Sprite[] resultBoard;
    [SerializeField] private GameObject[] items;
    private ItemModel _itemModel;

    private void Start()
    {
        _itemModel = GameObject.Find("ItemModel").GetComponent<ItemModel>();
    }


    public void DisplatResult(int win)
    {
        
        board.GetComponent<Image>().sprite = resultBoard[win];
        if (win != 0)
        {
            CheckItem();
        }
        board.transform.DOMove(new Vector2(0f, 0f), 0.5f).SetEase(Ease.OutBounce);
    }

    private void CheckItem()
    {
        int per = UnityEngine.Random.Range(0, 101);
        int sum = 0;
        for (int i = 0; i < _itemModel.num.Length; i++)
        {
            if (_itemModel.num[i] != 0)
            {
                sum += _itemModel.num[i];
                if (sum >= per)
                {
                    items[i].SetActive(true);
                    return;
                }
            }
        }
    }
}
