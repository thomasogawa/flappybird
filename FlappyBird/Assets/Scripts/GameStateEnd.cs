using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateEnd : GameStates
{
    public GameStateEnd(GameManager gameManager) : base(gameManager){}

    public override void EnterState()
    {
		Time.timeScale = 0;
        gameManager.GameResult.DisplayGameOverMenu();
    }

    public override void ExitState()
    {
		Time.timeScale = 1;
    }
}