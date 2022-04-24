using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfDestructScript : MonoBehaviour
{

    public float secondsToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroySelf());
    }

    IEnumerator DestroySelf(){
        yield return new WaitForSeconds(secondsToDestroy);
        Destroy(gameObject);
    }
}