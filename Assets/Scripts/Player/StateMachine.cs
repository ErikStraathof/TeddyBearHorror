using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    State activeState;

    public StateMachine()
    {
        activeState = null;
    }

    public void SwitchState(State state)
    {
        if (activeState != null)
        {
            activeState.Exit();
        }
        activeState = state;
        activeState.Enter();
    }
}
