using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    public Text ActiveScoreText;
	public Text EndScoreText;
	public GameObject TempTextPrefab;
    private int Score;
    
    public void IncrementScore()
    {
        Score++;
		if(Score < 10){
			ActiveScoreText.text = "0" + Score.ToString();
		}
		else {
        	ActiveScoreText.text = Score.ToString();
		}
		var tempText = Instantiate(TempTextPrefab, this.transform.position , Quaternion.identity);
    }

	public void UpdateEndTextScore(){
		EndScoreText.text = "Score: " + Score;
	}

	public void ResetScore()
	{
		Score = 0;
		ActiveScoreText.text = "00";
	}

	public int GetScore()
	{
		return Score;
	}
}
