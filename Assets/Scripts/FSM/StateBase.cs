using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateBase
{
    public int id { get; set; }
    public SlgObject owner { get; set; }
    public StateBase(SlgObject owner, int id)
    {
        this.owner = owner;
        this.id = id;
    }

    public virtual void  EnterExcute(params object[] _param) { }
    public virtual void Excute(float _deltatime, params object[] _param) { }
    public virtual void ExitExcute(params object[] _param) { }
}
