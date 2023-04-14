using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CameraWork : MonoBehaviour
{
    [SerializeField] private SceneChanger scene;

    [SerializeField] private float zoomPer;
    [SerializeField] private Image fade;

    public void ToBattleChange()
    {
        var cam = gameObject.GetComponent<Camera>();
        gameObject.transform.DOMove(new Vector2(0.0f, -2.0f), 1.2f)
            .OnUpdate(() => cam.orthographicSize -= Time.deltaTime * zoomPer)
            .OnComplete(() => scene.ChnageScene("PlayScene"));
        fade.DOFade(1.0f, 1.0f).SetEase(Ease.InQuad);
    }
}
