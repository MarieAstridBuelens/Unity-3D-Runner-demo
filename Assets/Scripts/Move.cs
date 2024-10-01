using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private Vector3 endPosition;

    [SerializeField] private float speed = 2f; // annonce valeur par défaut si on ne change rien. Double pas sérialisé dans Unity, on n'a que des floats
    //2f : si on fait un float, décimale ou pas, on met un f. Visuellement, permet de se rappeler que c'est un float. Mais en cas d'entier, conversion implicite

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, endPosition) >= 0.01f){ //transform.position = position actuelle
            Vector3 direction = (endPosition - startPosition).normalized;
            Vector3 movement = direction * speed * Time.deltaTime; //deltatime = temps entre deux frames.
            //transform.position += movement;
            //OU TRanslate : permet de faire mouvements relatifs ou dans le monde
            transform.Translate(movement);
        }
        else{
            transform.position = endPosition;
        }

            
    }
}
