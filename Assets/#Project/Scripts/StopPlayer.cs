using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPlayer : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.TryGetComponent(out PlayerControl playerControl)){
            //PlayerControl.commandsOn = false;
            //PlayerMove.speed = 0f;
            playerControl.enabled = false;
        }
        if(other.TryGetComponent(out PlayerMove move)){
            //PlayerControl.commandsOn = false;
            //PlayerMove.speed = 0f;
            move.enabled = false;
        }
    }
}
