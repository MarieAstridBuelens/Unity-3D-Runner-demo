using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 decal = new(0, 4, -8);
    

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + decal;
    }
}
