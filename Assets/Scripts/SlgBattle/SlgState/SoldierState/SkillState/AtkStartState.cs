using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkStartState : StateBase
{
    float curTime = 0f;
    float aniTime = 0f;
    public new SkillState owner { get; set; }
    public AtkStartState(SkillState owner, int id) : base(owner, id)
    {
        this.owner = owner;
    }
    public override void EnterExcute(params object[] _param)
    {
        owner.owner.DoAction("WAIT03");
        aniTime = Random.Range(5, 10);
        Debug.LogFormat("EnterExcute AtkStartState {0}", aniTime);
    }
    public override void Excute(float _deltatime, params object[] _param)
    {
        curTime += _deltatime;
        if (curTime> aniTime)
        {
            curTime = 0;
            owner.ChangeState((int)SlgConstants.SkillState.Atk);
        }
    }
    public override void ExitExcute(params object[] _param)
    {

    }
}
