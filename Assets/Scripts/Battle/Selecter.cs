using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Selecter : MonoBehaviour
{
    [SerializeField] private Vector2[] selectStatus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveSelecter(int status)
    {
        transform.DOLocalMove(selectStatus[status], 0.3f).SetEase(Ease.InCirc);
    }
}
