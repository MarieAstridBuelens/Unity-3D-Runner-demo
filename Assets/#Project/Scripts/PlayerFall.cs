using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall : MonoBehaviour
{
    void OnTriggerExit(Collider other){
      
        if(other.TryGetComponent<Transform>(out Transform transform) && other.transform.position.y < 0){//variable qui n'aura une existence qu'à l'intérieur du if
            other.transform.position = CollideObstacle.initialPosition;
            PlayerControl.canJump = true;
        }

    }
}
