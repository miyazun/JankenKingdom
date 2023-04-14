using DG.Tweening;
using Player;
using UnityEngine;

public class ExplainView : MonoBehaviour
{
    [SerializeField] private PlayerStatusController _playerStatusController;
    void Start()
    {
        transform.DOScale(new Vector2(1f, 1f), 0.3f).SetEase(Ease.OutBack).SetDelay(0.3f);
    }

    public void CloseExplain()
    {
        transform.DOScale(new Vector2(0f, 0f), 0.2f).OnComplete(() => _playerStatusController.FudaUI(0));
        gameObject.SetActive(false);
    }

}
