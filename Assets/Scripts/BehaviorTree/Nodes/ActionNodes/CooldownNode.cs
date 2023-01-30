using UnityEngine;

public class CooldownNode : ActionNode
{
    public float cooldown;
    private float timeStamp;

    public override void Enter()
    {
        timeStamp = Time.time;
    }

    public override BehaviorState Execute()
    {
        if (Time.time - timeStamp > Time.time)
        {
            Debug.Log("cooldown");
            state = BehaviorState.Success;
        }
        return state;
    }
}
