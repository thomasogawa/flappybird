using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public ObstacleSpawner ObstacleSpawner;
    [HideInInspector] public GameStatePlaying GameStatePlaying;
    [HideInInspector] public GameStatePaused GameStatePaused;
    [HideInInspector] public GameStateEnd GameStateEnd;

    public UnityEvent Reset;
    public Canvas PausedUI;
    public GameResults GameResult;
    public GameStates CurrentState;

    // Start is called before the first frame update
    void Awake()
    {
        GameStatePlaying = new GameStatePlaying(this);
        GameStateEnd = new GameStateEnd(this);
        GameStatePaused = new GameStatePaused(this);
    }
    
    public void UpdateState(GameStates newState)
    {
        if (newState == GameStatePlaying)
            print("reset");
            Reset.Invoke();
        if (null != CurrentState)
            CurrentState.ExitState();
        CurrentState = newState;
        print(newState);
        CurrentState.EnterState();
    }
    
    public void UpdateStateEnd()
    {
        UpdateState(GameStateEnd);
    }

    public void UpdateStatePause()
    {
        UpdateState(GameStatePaused);
    }
    
    public void UpdateStatePlay()
    {
        UpdateState(GameStatePlaying);
    }
}
