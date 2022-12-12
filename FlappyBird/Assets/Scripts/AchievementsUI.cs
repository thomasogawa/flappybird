using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementsUI : MonoBehaviour
{
    public Text achievement1;
    public Text achievement2;
    public Text achievement3;

    //Demonstration booleans that can be edited in the editor (set to false for No Check, set to true for Check✅)
    public bool isAchievement1Unlocked;
    public bool isAchievement2Unlocked;
    public bool isAchievement3Unlocked;
    
    //Call this in your Achievement script to change text color to signify the achievement has been unlocked.
     public void ChangeStatusTo(int achievementNumber, bool status)
     {
         switch (achievementNumber)
         {
             case 1:
                 isAchievement1Unlocked = status;
                 break;
             case 2:
                 isAchievement2Unlocked = status;
                 break;
             case 3:
                 isAchievement3Unlocked = status;
                 break;
         }
         UpdateChecks();
     }
    
    //This is called in order to change the visual checks✅ on this screen
    public void UpdateChecks()
    {

        if (isAchievement1Unlocked)
        {
            achievement1.color = Color.green;
        }
        else if (!isAchievement1Unlocked)
        {
            achievement1.color = Color.gray;
        }
        if (isAchievement2Unlocked)
        {
            achievement2.color = Color.green;
        }
        else if (!isAchievement2Unlocked)
        {
            achievement2.color = Color.gray;
        }
        if (isAchievement3Unlocked)
        {
            achievement3.color = Color.green;
        }
        else if (!isAchievement3Unlocked)
        {
            achievement3.color = Color.gray;
        }
    }
}
