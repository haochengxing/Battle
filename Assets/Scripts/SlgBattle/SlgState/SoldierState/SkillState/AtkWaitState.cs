using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkWaitState : StateBase
{
    float curTime = 0f;
    float aniTime = 0f;
    public new SkillState owner { get; set; }
    public AtkWaitState(SkillState owner, int id) : base(owner, id)
    {
        this.owner = owner;
    }
    public override void EnterExcute(params object[] _param)
    {
        aniTime = Random.Range(2, 5);
        Debug.LogFormat("EnterExcute AtkWaitState {0}", aniTime);
    }
    public override void Excute(float _deltatime, params object[] _param)
    {
        curTime += _deltatime;
        if (curTime > aniTime)
        {
            curTime = 0;
            owner.ChangeState((int)SlgConstants.SkillState.Reload);
        }
    }
    public override void ExitExcute(params object[] _param)
    {

    }
}
