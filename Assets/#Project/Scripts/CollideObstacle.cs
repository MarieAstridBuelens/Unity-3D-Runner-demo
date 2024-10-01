using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;


public class CollideObstacle : MonoBehaviour
{
    [SerializeField] public static Vector3 initialPosition;

    // void Start(){
    //     initialPosition = transform.position;
    // }
    
    // void OnCollisionEnter(Collision collision){
    //     if (collision.collider.CompareTag("Obstacle")){
    //         collision.transform.position = initialPosition;
    //         PlayerControl.canJump = true;
    //     }
    // }

    void OnTriggerEnter(Collider other){
      
        if(other.TryGetComponent<Transform>(out Transform transform)){//variable qui n'aura une existence qu'à l'intérieur du if
            if(other.TryGetComponent<Renderer>(out Renderer renderer)){
                other.transform.position = initialPosition;
                PlayerControl.canJump = true;
            }
            
        }

    }
}
