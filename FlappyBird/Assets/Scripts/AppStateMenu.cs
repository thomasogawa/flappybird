using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppStateMenu : AppStates
{
    public AppStateMenu(AppManager appManager) : base(appManager){}

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