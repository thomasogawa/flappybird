using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateEnd : GameStates
{
    public GameStateEnd(GameManager gameManager) : base(gameManager){}
    public override void EnterState()
    {
        SoundManager.Instance.Play(gameManager.DieNoise);
        SoundManager.Instance.StopMusic();
		Time.timeScale = 0;
        gameManager.GameResult.DisplayGameOverMenu();
        gameManager.FileHandler.WriteString(gameManager.ScoreHandler.GetScore().ToString());
        gameManager.FileHandler.ReadFileForAchievements();
        gameManager.Achievements.UnlockAchievements();
    }

    public override void ExitState()
    {
		Time.timeScale = 1;
    }
}