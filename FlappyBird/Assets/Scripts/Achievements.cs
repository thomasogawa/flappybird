using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour
{
    private AchievementsUI achievementsUI;
    private bool touchGrass = false;
    private bool uKnowOwen = false;
    private bool uThinkUrFunnyHuh = false;
    
    // Start is called before the first frame update
    void Start()
    {
        achievementsUI = GetComponent<AchievementsUI>();
    }

  
    public void UnlockAchievements()
    {
        achievementsUI.ChangeStatusTo(1, CheckTouchGrassAchievement());
        achievementsUI.ChangeStatusTo(2, CheckUKnowOwensAchievement());
        achievementsUI.ChangeStatusTo(3, CheckUThinkUrFunnyHuhAchievement());
    }

    //Will be invoked with InputHandler events. When Player moves, hasMoved gets set to true
    public void TouchGrassToTrue()
    {
        touchGrass = true;
    }

    //if this method gets invoked via an event, its variable gets set to true instead of false
    public void UKnowOwenToTrue()
    {
        uKnowOwen = true;
    }

    public void UThinkUrFunnyHuhToTrue()
    {
        uThinkUrFunnyHuh = true;
    }
    
    //if player has not moved, returns true to show achievement completed
    private bool CheckTouchGrassAchievement()
    {
        return touchGrass;
    }
    
    //if player got all three objects, returns true to show achievement completed
    private bool CheckUKnowOwensAchievement()
    {
        return uKnowOwen;
    }
    
    //if player got all objects, returns true to show achievement completed
    private bool CheckUThinkUrFunnyHuhAchievement()
    {
        return uThinkUrFunnyHuh;
    }
}
