using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
//     [SerializeField] private GameObject prefab;
//     [SerializeField] private float counter = 1f;
//     private bool counterOn = false;
    
//     // Start is called before the first frame update
//     void OnTriggerEnter(Collider other)
//     {
//         if(prefab != null && counterOn == false){
//             counterOn = true;
//             Instantiate(prefab, transform.position, transform.rotation);
//         }
//     }

//     void Update(){
//         if(counterOn && counter <=0){
//             counterOn = false;
//             counter = 1;
//         }

//         if (counterOn){
//             counter -= Time.deltaTime;
//         }
//     }

// OU
[SerializeField] private GameObject prefab;
    [SerializeField] private float coolDown = 0f;
    private float chrono = 0f;
    
    void OnTriggerEnter(Collider other)
    {
        if(chrono <=0F && prefab != null){
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }

    void Update(){
        if(chrono > 0f){
               chrono -= Time.deltaTime;
        }
    }


}
