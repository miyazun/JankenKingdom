using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PleaseTap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOJump(transform.position, 0.5f, 1, 1.0f).SetLoops(-1).SetLink(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
