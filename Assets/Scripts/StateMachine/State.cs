using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface State
{
    public void Enter();
    public void HandleInput();
    public void Execute();
    public void Exit();
}
