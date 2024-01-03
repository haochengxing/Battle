using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadState : StateBase
{
    float curTime = 0f;
    float aniTime = 0f;
    public new SkillState owner { get; set; }
    public ReloadState(SkillState owner, int id) : base(owner, id)
    {
        this.owner = owner;
    }
    public override void EnterExcute(params object[] _param)
    {
        owner.owner.DoAction("WAIT02");
        aniTime = Random.Range(4, 7);
        Debug.LogFormat("EnterExcute ReloadState {0}", aniTime);
    }
    public override void Excute(float _deltatime, params object[] _param)
    {
        curTime += _deltatime;
        if (curTime > aniTime)
        {
            curTime = 0;
            owner.ChangeState((int)SlgConstants.SkillState.StandBy);
        }
    }
    public override void ExitExcute(params object[] _param)
    {

    }
}
