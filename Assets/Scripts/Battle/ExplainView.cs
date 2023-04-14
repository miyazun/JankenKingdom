using DG.Tweening;
using Player;
using UnityEngine;
using UnityEngine.UI;

public class ExplainView : MonoBehaviour
{
    [SerializeField] private PlayerStatusController _playerStatusController;
    [SerializeField] private Image fade;
    void Start()
    {
        fade.DOFade(0.0f, 1.0f).SetEase(Ease.InQuad)
            .OnComplete(() => transform.DOScale(new Vector2(1f, 1f), 0.3f).SetEase(Ease.OutBack).SetDelay(0.3f));
    }

    public void CloseExplain()
    {
        transform.DOScale(new Vector2(0f, 0f), 0.2f).OnComplete(() => _playerStatusController.FudaUI(0));
        gameObject.SetActive(false);
    }

}
