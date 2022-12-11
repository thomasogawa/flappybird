using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppStateMenu : AppStates
{
    public AppStateMenu(AppManager appManager) : base(appManager){}

    public override void EnterState()
    {
        appManager.MenuPage.gameObject.SetActive(true);
    }

    public override void ExitState()
    {
        appManager.MenuPage.gameObject.SetActive(false);
    }
}