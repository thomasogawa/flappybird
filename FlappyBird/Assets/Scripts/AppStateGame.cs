using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppStateGame : AppStates
{
    public AppStateGame(AppManager appManager) : base(appManager){}

    public override void EnterState()
    {
        appManager.GamePage.gameObject.SetActive(true);
        
        appManager.GameManager.UpdateState(appManager.GameManager.GameStatePlaying);
    }

    public override void ExitState()
    {
        appManager.EndPage.gameObject.SetActive(false);
        appManager.GamePage.gameObject.SetActive(false);
    }
}