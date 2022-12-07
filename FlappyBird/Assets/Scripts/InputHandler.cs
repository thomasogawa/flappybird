/*Alan Lu & Thomas Ogawa
 * 2378209 & 2370770
 * allu@chapman.edu & togawa@chapman.edu
 * CPSC 245-01
 * Final Project
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputHandler : MonoBehaviour
{
    public UnityEvent onInputSpace;
    public UnityEvent onInputEnter;
    public UnityEvent onInputEsc;

    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SendMoveEvent(KeyCode.Space);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SendMoveEvent(KeyCode.Return);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SendMoveEvent(KeyCode.Escape);
        }
    }
    private void SendMoveEvent(KeyCode keycode)
    {
        switch (keycode)
        {
            case KeyCode.Space:
                onInputSpace.Invoke();
                break;
            case KeyCode.Return:
                onInputEnter.Invoke();
                break;
            case KeyCode.Escape:
                onInputEsc.Invoke();
                break;
        }
    }
}
