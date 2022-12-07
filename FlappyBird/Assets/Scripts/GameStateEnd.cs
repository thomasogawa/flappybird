using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateEnd : GameStates
{
    public GameStateEnd(GameManager gameManager) : base(gameManager){}

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