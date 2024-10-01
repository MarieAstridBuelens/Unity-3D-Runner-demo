using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] public static float speed = 2f;
    [SerializeField] private float cameraPlayerDistance = 4f;
    //[SerializeField] Transform cube; permet si on veut faire deux scripts de passer un autre objet dont le script dépend.
    
 
    private Vector3 cameraPosition;




// Update is called once per frame
void Update()
    {
        cameraPosition = new Vector3 (Camera.main.transform.position.x,  Camera.main.transform.position.y, transform.position.z - cameraPlayerDistance);
        Camera.main.transform.position = cameraPosition;
        Vector3 movement = Time.deltaTime * speed * transform.forward;
        transform.position += movement;
    }
}
