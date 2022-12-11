using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatePaused : GameStates
{
    public GameStatePaused(GameManager gameManager) : base(gameManager){}
    private float timer;

    public override void EnterState()
    {
        gameManager.PausedUI.gameObject.SetActive(true);
        PauseGame();
    }

    public override void ExitState()
    {
        gameManager.PausedUI.gameObject.SetActive(false);
        ResumeGame();
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
