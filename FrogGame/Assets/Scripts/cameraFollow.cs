using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed;


    // Update is called once per frame
    void Update()
    {
        

        if(target.position.x > (transform.position.x + (transform.position.x / 2))){
            Vector3 newPos = new Vector3(target.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime);
        }
        else {
            Vector3 newPos = new Vector3(transform.position.x + cameraSpeed, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime);
        }
    }
}
