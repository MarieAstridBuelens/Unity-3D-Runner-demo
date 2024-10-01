using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input_03 : MonoBehaviour
{
    
    [SerializeField] InputActionAsset inputActions;
    [SerializeField] private float speed = 1f;
    InputAction move;
    InputAction jump;
    InputAction run;

    //[SerializeField] InputActionReference actionRef; //permet de sélectionner les actions dans un menu Unity
    
    void OnEnable()
    {
        inputActions.FindActionMap("Player").Enable();
        move = inputActions["Move"];//utilisé comme un dictionnaire, donc crochets droits
        jump = inputActions["Jump"];
        run = inputActions["Run"];
    }
    void OnDisable()
    {
        inputActions.FindActionMap("Player").Disable();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        run.performed += OnShift;
    }

    // Update is called once per frame
    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard.shiftKey.wasReleasedThisFrame){
            speed/=2;
        }
        Vector3 moveAmount = move.ReadValue<Vector3>();
        Debug.Log(moveAmount);

        transform.position += new Vector3(moveAmount.x, moveAmount.y, moveAmount.z) * Time.deltaTime * speed;//y est sur le plan vertical sur Unity ><Blender où le y est horizontal
    }

    void OnShift(InputAction.CallbackContext context){
        speed *= 2;
    }
}
