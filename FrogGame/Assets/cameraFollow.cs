using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public float playerStandingPosition;


    // Update is called once per frame
    void LateUpdate()
    {
        if(target.position.x > transform.position.x){
            Vector3 newPos = new Vector3(target.position.x, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
        if(target.GetComponent<Rigidbody2D>().velocity.x == 0 && playerStandingPosition < (target.position.x - transform.position.x)){
            Vector3 newPos = new Vector3(target.position.x - playerStandingPosition, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime);
        }
    }
}
