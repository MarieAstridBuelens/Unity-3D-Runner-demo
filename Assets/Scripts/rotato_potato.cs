using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotato_potato : MonoBehaviour
{
    
    [SerializeField] float angularSpeed = 20f; //degrés par sec
    
   

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.rotation.eulerAngles;//eulerAngles contient la valeur en Vector3 en Quaternion. Quaternion = représentation mathématique d'un angle
        rotation.y += Time.deltaTime * angularSpeed; //deltatime permet de ne pas avoir les variations de la vitesse du processeur
        transform.rotation = Quaternion.Euler(rotation); // méthode statique Euler de la classe Quaternion prend les eulers et les transforme en quaternion
    }
}
