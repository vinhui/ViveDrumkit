using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

class OnKeyPress : MonoBehaviour
{
    public KeyCode key;

    public KeyEvent onKeyDown = new KeyEvent();
    public KeyEvent onKeyUp = new KeyEvent();
    public KeyEvent onKeyPressed = new KeyEvent();

    public void Update()
    {
        if (Input.GetKeyDown(key))
            onKeyDown.Invoke();
        if (Input.GetKeyUp(key))
            onKeyUp.Invoke();
        if (Input.GetKey(key))
            onKeyPressed.Invoke();
    }

    [System.Serializable]
    public class KeyEvent : UnityEvent { }
}
