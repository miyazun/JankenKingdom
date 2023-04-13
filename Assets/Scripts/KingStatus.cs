using Status;
using UnityEngine;

public class KingStatus : JankenStatusModel
{
    private void Start()
    {
        DecideStatus();
        Debug.Log(ReturnStatus());
    }

    private void DecideStatus()
    {
        SetStatus(UnityEngine.Random.Range(0, 4));
    }
}
