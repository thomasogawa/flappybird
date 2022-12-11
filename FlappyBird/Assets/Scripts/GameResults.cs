using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResults : MonoBehaviour
{
    public GameObject PlayingScoreUI;
    public GameObject PlayingUI;
    public GameObject ResultUI;
    public ScoreHandler ScoreHandler;


    // Update is called once per frame
    public void DisplayGameOverMenu()
    {
        PlayingScoreUI.SetActive(false);
        ScoreHandler.UpdateEndTextScore();
        ResultUI.SetActive(true);
    }

    public void RemoveEndUI()
    {
        ResultUI.SetActive(false);
    }
}
