using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using System.Net.NetworkInformation;

[RequireComponent(typeof(Rigidbody))]
public class PlayerControl : MonoBehaviour
{

    //public InputActions actions;

    public InputActionAsset actions;
    public float speed = 1f;
    [SerializeField] private float jumpIntensity = 10f;
    private InputAction xAxis;
    private InputAction jump;
    [SerializeField] Transform plane;
    public static bool canJump = true;
    public static bool commandsOn = true;

    private bool Grounded{get{
        if(Physics.Raycast(transform.position, Vector3.down, 0.6f)){
            return true;
        }
        return false;
    }}//propriété
   

    void Awake()
    {
        xAxis = actions.FindActionMap("CubeActionsMap").FindAction("XAxis");
        jump = actions.FindActionMap("CubeActionsMap").FindAction("jump");
    }

    void OnEnable()
    {
        actions.FindActionMap("CubeActionsMap").Enable();
    }

    void OnDisable()
    {
        actions.FindActionMap("CubeActionsMap").Disable();
    }

    void Update()
    {
        MoveX();
        if (canJump)
        {
            Jump();
        }
        if(transform.position.y < -4){
                transform.position = CollideObstacle.initialPosition;
                canJump = true;
            }
    }

    private void MoveX()
    {
        if (commandsOn){
            float xMove = xAxis.ReadValue<float>();
            transform.position += speed * Time.deltaTime * xMove * transform.right;//.right, .forward... : déjà normalisé
        }
        

    }

    private void Jump()
    {
        if (commandsOn){
            if(!Grounded) return;
            float jumpAmount = jump.ReadValue<float>();
            if(jumpAmount > 0f){//càd quand on appuie sur la touche espace
            GetComponent<Rigidbody>().AddForce(jumpIntensity * Vector3.up);//force est là tant que la gravité n'est pas là pour la compenser
            }
        }
    }

//     private void OnTriggerEnter(Collider other){
//         if(other.transform == plane){
//             canJump = true;
//         }
//     }

//         private void OnTriggerExit(Collider other){
//         if(other.transform == plane){
//             canJump = false;
//         }
//     }
}
