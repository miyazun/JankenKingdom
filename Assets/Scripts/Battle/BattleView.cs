using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleView : MonoBehaviour
{
    //左下に出る選んだ自分の手
    [SerializeField] private Sprite[] selectStatus;
    //王様の立ち絵
    [SerializeField] private Sprite[] kingStand;
    //王様の持つ札
    [SerializeField] private Sprite[] kingStatus;
    //数字の画像
    [SerializeField] private Sprite[] Num;
    //左下の手の欄
    [SerializeField] private Image select;
    //勝利数を示す右上のboard
    [SerializeField] private Image winBoard;
    //勝利数のboardの中の数字
    [SerializeField] private Image wins;
    //王様のオブジェクトの画像
    [SerializeField] private SpriteRenderer kingObj;

    public void DisplayResult(int player, int king, int result, int winNum)
    {
        
    }
}
