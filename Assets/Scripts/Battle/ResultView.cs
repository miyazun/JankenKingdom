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
        board.transform.DOScale(new Vector2(1f, 1f), 0.5f);
        
    }
}
