using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraWork : MonoBehaviour
{
    [SerializeField] private SceneChanger scene;

    [SerializeField] private float zoomPer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToBattleChange()
    {
        var cam = gameObject.GetComponent<Camera>();
        gameObject.transform.DOMove(new Vector2(0.0f, -2.0f), 1f).OnUpdate(() => cam.orthographicSize -= Time.deltaTime * zoomPer).OnComplete(() => scene.ChnageScene("PlayScene"));
    }
}
