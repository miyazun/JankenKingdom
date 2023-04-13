using System;
using System.Collections;
using System.Collections.Generic;
using King;
using Player;
using UnityEngine;

public class BattleResult : MonoBehaviour
{
    private int turn = 0;
    //王様の手
    [SerializeField] private KingStatusModel king;
    //プレイヤの手
    [SerializeField] private PlayerStatusModel player;
    //結果を表示するview
    //[SerializeField] private BattleView _battleView;

    private void Start()
    {
        turn = 0;
    }

    public void WinnerCheck()
    {
        int result = 0;
        result = (player.ReturnStatus() - king.DecideStatus() + 3) % 3;
        Debug.Log(result);
        //_battleView.DisplayResult(result, king.ReturnStatus());
        turn++;
    }
}
