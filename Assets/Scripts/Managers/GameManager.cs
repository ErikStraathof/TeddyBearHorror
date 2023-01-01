using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{ 
    Starting,
    Running,
    Paused,
    Ending
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private GameState currentState;

    void Awake()
    {
        instance = this;
        SwitchState(GameState.Starting);
    }

    public void SwitchState(GameState gameState)
    {
        currentState = gameState;

        switch (gameState)
        {
            case GameState.Starting:
                break;
            case GameState.Running:
                break;
            case GameState.Paused:
                break;
            case GameState.Ending:
                break;
            default:
                break;
        }
    }
}
