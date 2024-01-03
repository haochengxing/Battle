using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopPathInfo
{
    List<Ground.Position> positionList;
    int pathHeight;
    Dictionary<int, SlgGroupBase> groupList = new Dictionary<int, SlgGroupBase>();
    SlgConstants.TroopPath pathId;
    SlgConstants.Camp camp;
    SlgConstants.Seat seat;
    int logicX;
    int logicZ;
    public TroopPathInfo(SlgConstants.TroopPath pathId, SlgConstants.Camp camp, SlgConstants.Seat seat)
    {
        this.pathId = pathId;
        this.camp = camp;
        this.seat = seat;
        Ground pathData = Ground.DataList[(int)pathId];
        positionList = pathData.positionList;
        pathHeight = pathData.pathHeight;
    }
    public void Add(int groupId)
    {
        SoldierGroup groupInfo = new SoldierGroup(camp, seat);
        ResetPosition(groupInfo);
        groupInfo.Init(pathId);
        groupList.Add(groupId, groupInfo);
    }
    public void Update(float deltaTime)
    {
        foreach (var item in groupList)
        {
            item.Value.Update(deltaTime);
        }
    }
    public int GetCurrentHeight()
    {
        return pathHeight;
    }
    public void SetPosition(int x,int z)
    {
        logicX = x;
        logicZ = z;
    }
    public void ResetPosition(SoldierGroup groupInfo)
    {
        Ground.Position position = positionList[2];
        if (seat == SlgConstants.Seat.left)
        {
            groupInfo.SetLogicPosition(logicX - position.posX, logicZ + position.posY);
        }
        else
        {
            groupInfo.SetLogicPosition(logicX + position.posX, logicZ + position.posY);
        }
    }
    public void StartAtk()
    {
        foreach (var item in groupList)
        {
            item.Value.StartAtk();
        }
    }
}
