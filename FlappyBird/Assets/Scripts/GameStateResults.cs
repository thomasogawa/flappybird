using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateResults : GameStates
{
    public GameStateResults(GameManager gameManager) : base(gameManager){}

    public override void EnterState()
    {
        //Turn on Game Canvas/Scene
        //Reset Everything
    }

    public override void ExitState()
    {
        //Turn off Game Canvas/Scene
        
    }
}
