using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class SlgWarPlay : SlgObject
{
    StateMachine stateMachine;
    public SlgWarPlay()
    {
        stateMachine = new StateMachine();
        stateMachine.Add(new PlayState(this,(int)SlgConstants.PlayState.Play));
        stateMachine.Add(new FailState(this,(int)SlgConstants.PlayState.Fail));
        stateMachine.Add(new WinnState(this,(int)SlgConstants.PlayState.Winn));
        stateMachine.Add(new NullState(this,(int)SlgConstants.PlayState.Null));
    }

    public void Init()
    {
        Ground.Init();
        SlgConstants.Seat seat = SlgConstants.Seat.right;
        SlgMapInfo.Instance.Init(0,0,0);
        TroopMgr.Instance.Init(seat);

        stateMachine.ChangeState((int)SlgConstants.PlayState.Play);
    }
    public void Update(float deltaTime)
    {
        stateMachine.Excute(deltaTime);
    }
    public void StartAtk()
    {
        TroopMgr.Instance.StartAtk();
    }
}
