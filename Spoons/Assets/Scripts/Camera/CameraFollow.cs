using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    public Transform target;
    public Vector3 offset;
    [Range(1,10)]
    public float smoothBrain;

    private void FixedUpdate()
    {
        Follow();
    }

    void Follow()

        {
            // Vector3 targetPosition =  target.position+offset;
            // Vector3 smoothPosition = Vector3.Lerp(transform.position.x, target.position.y, smoothBrain*Time.fixedDeltaTime);
            // transform.position = smoothPosition;
            
            Vector3 newPosition = new Vector3(target.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPosition, smoothBrain * Time.deltaTime);
        }
    
}
