using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input_02 : MonoBehaviour
{
    [SerializeField] InputAction move;
    [SerializeField] InputAction jump;

    
    void OnEnable(){ //qd script est lancé, enable les 2 actions
        move.Enable();
        jump.Enable();
    }

    void OnDisable(){ //qd script s'arrête, disable les 2 actions
        move.Disable();
        jump.Disable();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        jump.performed += OnJump;//si OnJump(), va pas marcher car on rajouterait le résultat de la fonction, pas la fonction en elle-même
        //jump.performed += ctx => {OnJump(ctx);}; //fonction anonyme : ça bricole un argument et ça le passe à la fonction
    }

    // Update is called once per frame
    void Update()
    {
        // if(jump.WasPerformedThisFrame()){
        //     Debug.Log("Jump!");
        // }

        float moveAmount = move.ReadValue<float>(); // ReadValue : demande à l'action quelle est sa valeur
        //quand on est sur un axe c'est un float, pour quatre direction c'est un vector2, pour la 3D c'est vector3
        Debug.Log(moveAmount);

        Vector3 movementVector = new Vector3 (moveAmount * Time.deltaTime, 0, 0);
        transform.position += movementVector;

        //OU
        //transform.position += moveAmount * Vector3.right * Time.deltaTime;

    }

    void OnJump (InputAction.CallbackContext context){
        Debug.Log("New jump!");
    }
}
