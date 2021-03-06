using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class List : MonoBehaviour
{
    private List<Direction> Dirlist = new List<Direction>();     //Listの宣言

    public enum Direction
    {      //enumの定義
        Straight,
        Back,
        Left,
        Right
    }

    public void StraightButton()
    {
        Dirlist.Add(Direction.Straight);
    }

    public void BackButton()
    {
        Dirlist.Add(Direction.Back);
    }

    public void RightButton()
    {
        Dirlist.Add(Direction.Right);
    }

    public void LeftButton()
    {
        Dirlist.Add(Direction.Left);
    }

    public void SearchButton()
    {
        Search();
    }

    async void Search()
    {
        foreach (Direction dir in Dirlist)
        {
            Debug.Log(dir.ToString());
            await Task.Delay(2000);
        }
    }
}
