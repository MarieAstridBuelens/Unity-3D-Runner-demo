using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] float scale = 2f;
    
    private void OnTriggerEnter(Collider other){
        other.transform.localScale *= scale;
    }

    private void OnTriggerExit(Collider other){
        other.transform.localScale /= scale;
    }
}
