using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatePlaying : GameStates
{
    public GameStatePlaying(GameManager gameManager) : base(gameManager){}
    private float timer;

    public override void EnterState()
    {
        SoundManager.Instance.PlayMusic(gameManager.BackgroundMusic);
        Time.timeScale = 1;
        gameManager.ObstacleSpawner.SpawnMultipleObstacles();
    }

    public override void ExitState()
    {
        gameManager.ObstacleSpawner.PauseSpawning();
    }

}
