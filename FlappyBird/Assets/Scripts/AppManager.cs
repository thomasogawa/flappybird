using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AppManager : MonoBehaviour
{
    public GameManager GameManager;
    [HideInInspector] public AppStateAcheivement AppStateAcheivement;
    [HideInInspector] public AppStateGame AppStateGame;
    [HideInInspector] public AppStateMenu AppStateMenu;
    
    public AppStates CurrentState;

    public UnityEvent SwitchState;
    public Canvas AcheivementPage;
    public Canvas MenuPage;
    public Canvas GamePage;
    public Canvas EndPage;
    
    private float timer;
    // Start is called before the first frame update
    void Awake()
    {
        AppStateAcheivement = new AppStateAcheivement(this);
        AppStateGame = new AppStateGame(this);
        AppStateMenu = new AppStateMenu(this);
        UpdateState(AppStateMenu);
    }

    
    public void UpdateState(AppStates newState)
    {
        SwitchState.Invoke();
        if (null != CurrentState)
            CurrentState.ExitState();
        CurrentState = newState;
        CurrentState.EnterState();
    }

    public void SwitchStateAcheivement()
    {
        UpdateState(AppStateAcheivement);
    }
    public void SwitchStateGame()
    {
        UpdateState(AppStateGame);
    }
    public void SwitchStateMenu()
    {
        UpdateState(AppStateMenu);
    }
}
