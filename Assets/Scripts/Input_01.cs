using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input_01 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Keyboard keyboard = Keyboard.current; //on prend celui avec lequel on a interagi en dernier
        
        if (keyboard.aKey.wasPressedThisFrame){
            Debug.Log("a was pressed!");
        }

    }
}
