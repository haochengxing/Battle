using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlgSoldierInfo : SlgRoleBase
{
    StateMachine stateMachine;
    public SlgSoldierInfo()
    {
        stateMachine = new StateMachine();
        stateMachine.Add(new IdleState(this, (int)SlgConstants.SoldierState.Idle));
        stateMachine.Add(new MoveState(this, (int)SlgConstants.SoldierState.Move));
        stateMachine.Add(new SkillState(this, (int)SlgConstants.SoldierState.Skill));
        stateMachine.Add(new WinState(this, (int)SlgConstants.SoldierState.Win));
        stateMachine.Add(new DeadState(this, (int)SlgConstants.SoldierState.Dead));
    }
    public override void Init()
    {
        
    }

    public override void Update(float deltaTime)
    {
        stateMachine.Excute(deltaTime);
    }

    public override void Release()
    {

    }
    public override void SetView(SlgRoleViewBase view)
    {
        base.SetView(view);
        stateMachine.ChangeState((int)SlgConstants.SoldierState.Idle);
    }
    public override void StartAtk()
    {
        stateMachine.ChangeState((int)SlgConstants.SoldierState.Skill);
    }
}
