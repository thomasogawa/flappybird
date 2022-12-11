using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppStateAcheivement : AppStates
{
    public AppStateAcheivement(AppManager appManager) : base(appManager){}

    public override void EnterState()
    {
        appManager.AcheivementPage.gameObject.SetActive(true);
    }

    public override void ExitState()
    {
        appManager.AcheivementPage.gameObject.SetActive(false);
        
    }
}
