using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class StateMachine
{
    StateBase currentState;
    Dictionary<int, StateBase> stateList = new Dictionary<int, StateBase>();
    float curTime = 0;
    public void Add(StateBase _state)
    {
        stateList.Add(_state.id, _state);
    }
    public StateBase Get(int _id)
    {
        return stateList[_id];
    }
    public void Excute(float _deltatime, params object[] _param)
    {
        curTime += _deltatime;
        if (currentState!=null)
        {
            currentState.Excute(_deltatime, _param);
        }
    }
    public void ChangeState(int _id, params object[] _param)
    {
        StateBase _newState = Get(_id);
        if (currentState==null)
        {
            currentState = _newState;
            currentState.EnterExcute(_param);
        }
        else
        {
            currentState.ExitExcute(_param);
            currentState = _newState;
            currentState.EnterExcute(_param);
        }
    }
    public int GetCurrentState()
    {
        if (currentState==null)
        {
            return -1;
        }
        else
        {
            return currentState.id;
        }
    }
}
