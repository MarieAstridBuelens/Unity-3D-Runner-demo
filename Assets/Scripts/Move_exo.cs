using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_exo : MonoBehaviour
{

[SerializeField] private float speed = 1f;
[SerializeField] private Vector3 direction;


void OnTriggerStay(){
    
    // float movement = speed * Time.deltaTime;
    // Vector3 movementVector = new Vector3 (movement, 0, 0);
    // transform.Translate(movementVector);

 
    transform.position += direction.normalized * Time.deltaTime * speed;
    // += : mouvement continu comme le update, se fait à chaque frame tant qu'il y a qq chose dans le trigger
    //normalisé = vecteur divisé par sa longueur, dans la bonne direction
}


}
