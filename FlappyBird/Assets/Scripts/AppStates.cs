using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppStates 
{
    public enum CurrentAppState
    {
        StateMainMenu, StateAcheivements, StateGame
    }

    protected AppManager appManager;

    public AppStates(AppManager manager)
    {
        appManager = manager;
    }
    
    public virtual void EnterState(){}
    public virtual void ExitState(){}
    public virtual void UpdateState(){}
    public virtual void OnEventReceived(){}
}


