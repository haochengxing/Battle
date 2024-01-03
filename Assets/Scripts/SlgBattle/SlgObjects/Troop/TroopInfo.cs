using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopInfo
{
    Dictionary<SlgConstants.TroopPath, TroopPathInfo> pathList = new Dictionary<SlgConstants.TroopPath, TroopPathInfo>();
    SlgConstants.Camp camp;
    SlgConstants.Seat seat;
    int logicX;
    int logicZ;
    public TroopInfo(SlgConstants.Camp camp, SlgConstants.Seat seat,int x,int z)
    {
        this.camp = camp;
        this.seat = seat;
        logicX = x;
        logicZ = z;
    }
    public void Init()
    {
        pathList.Add(SlgConstants.TroopPath.Up, new TroopPathInfo(SlgConstants.TroopPath.Up, camp, seat));
        pathList.Add(SlgConstants.TroopPath.Middle, new TroopPathInfo(SlgConstants.TroopPath.Middle, camp, seat));
        pathList.Add(SlgConstants.TroopPath.Down, new TroopPathInfo(SlgConstants.TroopPath.Down, camp, seat));

        ResetPosition();

        foreach (var item in pathList)
        {
            item.Value.Add(1);
        }
    }
    public void Update(float deltaTime)
    {
        foreach (var item in pathList)
        {
            item.Value.Update(deltaTime);
        }
    }
    public void ResetPosition()
    {
        int totalHeight = 0;
        foreach (var item in pathList)
        {
            totalHeight += item.Value.GetCurrentHeight();
        }
        int upPointZ = Mathf.CeilToInt(totalHeight / 2);
        int deltaHeight = 0;
        foreach (var item in pathList)
        {
            deltaHeight += item.Value.GetCurrentHeight();
            int logicZ = upPointZ - deltaHeight;
            item.Value.SetPosition(this.logicX, logicZ);
        }
    }
    public void StartAtk()
    {
        foreach (var item in pathList)
        {
            item.Value.StartAtk();
        }
    }
}
