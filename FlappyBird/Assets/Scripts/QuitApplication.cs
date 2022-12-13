using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    public void OnButtonClickQuit()
    {
        print("Exiting module");
        Application.Quit();
    }
}