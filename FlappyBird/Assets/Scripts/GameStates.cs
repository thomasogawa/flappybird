using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStates
{
    public enum CurrentGameState
    {
        StateGamePlaying, StateEndGame, StateResults
    }

    protected GameManager gameManager;

    public GameStates(GameManager manager)
    {
        gameManager = manager;
    }
    
    public virtual void EnterState(){}
    public virtual void ExitState(){}
    public virtual void UpdateState(){}
    public virtual void OnEventReceived(){}
}
