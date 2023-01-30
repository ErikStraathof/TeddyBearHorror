using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public abstract class BehaviorNode : ScriptableObject
{
    public string GUID;
    public BehaviorNode parent = null;
    public BehaviorState state = BehaviorState.Running;
    public bool isRoot = false;
    public bool started = false;

    public BehaviorState Update()
    {
        if (!started)
        {
            Enter();
            started = true;
        }

        state = Execute();

        if (state == BehaviorState.Success || state == BehaviorState.Failure)
        {
            Exit();
        }
        return state;
    }

    public abstract void Enter();
    public abstract BehaviorState Execute();
    public virtual void Exit()
    {
        Debug.Log("Exit");
    }
}
