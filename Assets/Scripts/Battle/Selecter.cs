using DG.Tweening;
using UnityEngine;

public class Selecter : MonoBehaviour
{
    [SerializeField] private Vector2[] selectStatus;
    public void MoveSelecter(int status)
    {
        transform.DOLocalMove(selectStatus[status], 0.3f).SetEase(Ease.InCirc);
    }
}
