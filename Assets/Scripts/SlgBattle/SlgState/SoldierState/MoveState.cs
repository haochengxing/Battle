using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : StateBase
{
    public new SlgSoldierInfo owner { get; set; }
    public MoveState(SlgSoldierInfo owner, int id):base(owner, id)
    {
        this.owner = owner;
    }
    public override void EnterExcute(params object[] _param)
    {
        
    }
    public override void Excute(float _deltatime, params object[] _param)
    {
        
    }
    public override void ExitExcute(params object[] _param)
    {
        
    }
}
