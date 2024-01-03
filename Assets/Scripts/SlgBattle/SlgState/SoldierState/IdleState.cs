using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : StateBase
{
    public new SlgSoldierInfo owner { get; set; }
    public IdleState(SlgSoldierInfo owner, int id):base(owner, id)
    {
        this.owner = owner;
    }
    public override void EnterExcute(params object[] _param)
    {
        owner.DoAction("WAIT00");
    }
    public override void Excute(float _deltatime, params object[] _param)
    {
        
    }
    public override void ExitExcute(params object[] _param)
    {
        
    }
}
