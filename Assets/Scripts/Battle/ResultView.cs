using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ResultView : MonoBehaviour
{
    [SerializeField] private GameObject board;
    [SerializeField] private Sprite[] resultBoard;


    public void DisplatResult(int win)
    {
        board.GetComponent<Image>().sprite = resultBoard[win];
        board.transform.DOMove(new Vector2(0f, 0f), 0.5f).SetEase(Ease.OutBounce);
        
    }
}
