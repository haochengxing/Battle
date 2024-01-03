using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullState : StateBase
{
    public NullState(SlgObject owner, int id) : base(owner, id)
    {
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