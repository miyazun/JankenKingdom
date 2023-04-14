using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DoorMove : MonoBehaviour
{
    [SerializeField] private GameObject right;
    [SerializeField] private GameObject left;

    private void Start()
    {
        OpenDoor();
    }

    public void OpenDoor()
    {
        right.transform.DORotate(new Vector3(0.0f, 90.0f, 0.0f), 1f);
        left.transform.DORotate(new Vector3(0.0f, -90.0f, 0.0f), 1f);
    }
}
