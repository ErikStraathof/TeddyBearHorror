using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    private Dictionary<string, State> states;
    private State activeState;

    public StateMachine()
    {
        activeState = null;
    }

    public void SwitchState(string command)
    {
        if (activeState != null)
        {
            activeState.Exit();
        }
        State nextState = states[command];
        nextState.Enter();
        activeState = nextState;
    }

    public void HandleInput()
    {
        activeState.HandleInput();
    }

    public void Excecute()
    {
        activeState.Execute();
    }

    public void AddState(string command, State state)
    {
        states.Add(command, state);
    }

    public void RemoveState(string command)
    {
        states.Remove(command);
    }
}
