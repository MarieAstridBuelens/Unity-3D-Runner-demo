using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyColor : MonoBehaviour
{
    [SerializeField] private Color color = Color.blue;

    private Color startColor;
    private GameObject memoObject = null; //GameObject = classe et ensemble de composants


    void OnTriggerEnter(Collider other){
        
        if (memoObject != null) return; // veut dire qu'il y a déjà un objet qui est rentré
        
        if(other.TryGetComponent<Renderer>(out Renderer renderer)){//variable qui n'aura une existence qu'à l'intérieur du if

            startColor = renderer.material.color;
            memoObject = other.gameObject;
            renderer.material.color = color;

        }

    }

    void OnTriggerStay(Collider other){
        other.transform.localScale *= 0.9f; //tjrs en local car scale est toujours en rapport avec qq chose d'autre. Par rapport au monde, trop compliqué pour Unity
    }

    
    void OnTriggerExit(Collider other){
        if(memoObject != null && other.gameObject == memoObject)
        {
            other.GetComponent<Renderer>().material.color = startColor;
            memoObject = null;

        }
        }
        
}


