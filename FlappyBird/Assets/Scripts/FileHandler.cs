using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using JetBrains.Annotations;
using UnityEngine.Events;

public class FileHandler : MonoBehaviour
{
    public UnityEvent TouchGrass;
    public UnityEvent UKnowOwen;
    public UnityEvent UThinkUrFunnyHuh;
    public void WriteString(string fileData)
    {
        Debug.Log("Trying to write to file");
        string path = "Assets/SavedData/playerData.txt";//Change this to be correct path
        
        //Write some text to test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(fileData);
        writer.Close();
        Debug.Log("Wrote to file");
    }

    public void ReadFileForAchievements()
    {
        List<int> userScores = new List<int>();
        string path = "Assets/SavedData/playerData.txt"; // Will ned to change this directory
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        
        while (reader.Peek() > -1)
        {
            userScores.Add(Convert.ToInt32(reader.ReadLine())); //when adding back remove the other debug log right below or too many lines will be read
            // Debug.Log(reader.ReadLine());
        }

        if (userScores.Count >= 10)
        {
            TouchGrass.Invoke();
            Debug.Log("Over 10 games player");
        }

        if (userScores[userScores.Count - 1] == 0)
        {
            UKnowOwen.Invoke();
            Debug.Log("Scored 0");
        }

        if (userScores[userScores.Count - 1] == 69)
        {
            UThinkUrFunnyHuh.Invoke();
            Debug.Log("Scored 69");
        }
        
        Debug.Log(userScores.Count);
        reader.Close();
    }
}
