using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillEndState : StateBase
{
    float curTime = 0f;
    float aniTime = 0f;
    public new SkillState owner { get; set; }
    public SkillEndState(SkillState owner, int id) : base(owner, id)
    {
        this.owner = owner;
    }
    public override void EnterExcute(params object[] _param)
    {
        owner.owner.DoAction("JUMP00");
        aniTime = Random.Range(1, 3);
        Debug.LogFormat("EnterExcute SkillEndState {0}", aniTime);
    }
    public override void Excute(float _deltatime, params object[] _param)
    {
        curTime += _deltatime;
        if (curTime > aniTime)
        {
            curTime = 0;
            owner.ChangeState((int)SlgConstants.SkillState.AtkStart);
        }
    }
    public override void ExitExcute(params object[] _param)
    {

    }
}
