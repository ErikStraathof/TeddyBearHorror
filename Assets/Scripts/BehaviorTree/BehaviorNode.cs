using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NodeState
{
    Running,
    Success,
    Failure
}

public abstract class BehaviorNode
{
    public BehaviorNode parent;
    public NodeState state;

    public virtual void Enter()
    {
        state = NodeState.Running;
        Execute();
    }

    public abstract void Execute();
}
