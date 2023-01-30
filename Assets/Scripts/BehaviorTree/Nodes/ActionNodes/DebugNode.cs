using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugNode : ActionNode
{
    public override void Enter()
    {
        Debug.Log("OnEnter");
    }

    public override BehaviorState Execute()
    {
        Debug.Log("OnUpdate");
        return BehaviorState.Success;
    }

    public override void Exit()
    {
        Debug.Log("OnExit");
    }
}
