using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SlgGroupBase
{
    public int order = 0;
    SlgFormation formation;
    int roleGID;
    SlgConstants.Camp camp;
    SlgConstants.Seat seat;
    int logicX;
    int logicZ;
    Dictionary<int, SlgRoleBase> roleList = new Dictionary<int, SlgRoleBase>();
    public SlgGroupBase(SlgConstants.Camp camp, SlgConstants.Seat seat)
    {
        this.camp = camp;
        this.seat = seat;
    }
    public virtual void Init(SlgConstants.TroopPath pathId) 
    {
        roleGID = 0;
        formation = new SlgFormation();
        formation.Init(pathId);
        InitBasse();
    }
    public virtual void Update(float deltaTime)
    {
        foreach (var item in roleList)
        {
            item.Value.Update(deltaTime);
        }
    }
    public SlgSoldierInfo AddModel() 
    {
        roleGID++;
        SlgSoldierInfo roleInfo = new SlgSoldierInfo();
        SlgSoldierView roleView = new SlgSoldierView();
        roleInfo.gId = roleGID;
        roleInfo.Init();
        roleView.Init(roleInfo);
        roleInfo.SetView(roleView);
        roleList.Add(roleGID, roleInfo);
        return roleInfo;
    }
    public void InitBasse()
    {
        int roleIndex = 0;
        for (int i = 0; i < 3; i++)
        {
            SlgSoldierInfo roleInfo = AddModel();
            InitRole(roleInfo, roleIndex);
            roleIndex++;
        }
    }
    public void InitRole(SlgSoldierInfo roleInfo, int roleIndex)
    {
        Vector2 gridXZ = formation.positionList[roleIndex];
        roleInfo.SetLogicPosition((int)gridXZ.x, (int)gridXZ.y);
        if (seat == SlgConstants.Seat.left)
        {
            Vector3 position = SlgMapInfo.Instance.GetGridPosition(logicX - roleInfo.logicX, logicZ + roleInfo.logicZ);
            roleInfo.SetPosition(position);
            roleInfo.SetRotationY((float)SlgConstants.RotationY.Left);
        }
        else
        {
            Vector3 position = SlgMapInfo.Instance.GetGridPosition(logicX + roleInfo.logicX, logicZ + roleInfo.logicZ);
            roleInfo.SetPosition(position);
            roleInfo.SetRotationY((float)SlgConstants.RotationY.Right);
        }
    }
    public void SetLogicPosition(int x,int z)
    {
        logicX = x;
        logicZ = z;
    }
    public void StartAtk()
    {
        foreach (var item in roleList)
        {
            item.Value.StartAtk();
        }
    }
}
