using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillState : StateBase, SlgObject
{
    StateMachine stateMachine;
    public new SlgSoldierInfo owner { get; set; }
    public SkillState(SlgSoldierInfo owner, int id):base(owner, id)
    {
        this.owner = owner;
        stateMachine = new StateMachine();
        stateMachine.Add(new AtkStartState(this, (int)SlgConstants.SkillState.AtkStart));
        stateMachine.Add(new AtkState(this, (int)SlgConstants.SkillState.Atk));
        stateMachine.Add(new AtkEndState(this, (int)SlgConstants.SkillState.AtkEnd));
        stateMachine.Add(new AtkWaitState(this, (int)SlgConstants.SkillState.AtkWait));
        stateMachine.Add(new ReloadState(this, (int)SlgConstants.SkillState.Reload));
        stateMachine.Add(new StandByState(this, (int)SlgConstants.SkillState.StandBy));
        stateMachine.Add(new SkillEndState(this, (int)SlgConstants.SkillState.SkillEnd));
    }
    public override void EnterExcute(params object[] _param)
    {
        ChangeState((int)SlgConstants.SkillState.AtkStart);
    }
    public override void Excute(float _deltatime, params object[] _param)
    {
        stateMachine.Excute(_deltatime, _param);
    }
    public override void ExitExcute(params object[] _param)
    {
        
    }
    public void ChangeState(int _id)
    {
        stateMachine.ChangeState(_id);
    }
}
