using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceNode : CompositeNode
{
    private int current;

    public override void Enter()
    {
        current = 0;
    }

    public override BehaviorState Execute()
    {
        var child = children[current];
        switch (child.Update())
        {
            case BehaviorState.Running:
                return BehaviorState.Running;
            case BehaviorState.Failure:
                return BehaviorState.Failure;
            case BehaviorState.Success:
                current++;
                break;
        }

        if (current > children.Count)
        {
            return BehaviorState.Success;
        }
        return BehaviorState.Running; 
    }
}
