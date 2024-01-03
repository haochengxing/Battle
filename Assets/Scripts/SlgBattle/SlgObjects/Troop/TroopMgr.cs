using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopMgr : Singleton<TroopMgr>
{
    public TroopInfo atkTroop;
    public TroopInfo defTroop;
    public TroopMgr()
    {

    }
    public void Init(SlgConstants.Seat seat)
    {
        if (seat == SlgConstants.Seat.left)
        {
            atkTroop = new TroopInfo(SlgConstants.Camp.atk, SlgConstants.Seat.left, -1, 0);
            defTroop = new TroopInfo(SlgConstants.Camp.def, SlgConstants.Seat.right, 1, 0);
        }
        else
        {
            atkTroop = new TroopInfo(SlgConstants.Camp.atk, SlgConstants.Seat.right, 1, 0);
            defTroop = new TroopInfo(SlgConstants.Camp.def, SlgConstants.Seat.left, -1, 0);
        }

        atkTroop.Init();
        defTroop.Init();
    }
    public void Update(float deltaTime)
    {
        atkTroop.Update(deltaTime);
        defTroop.Update(deltaTime);
    }
    public void StartAtk()
    {
        atkTroop.StartAtk();
        defTroop.StartAtk();
    }
}
