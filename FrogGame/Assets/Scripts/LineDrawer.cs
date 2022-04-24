using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{

    public Transform player;
    LineRenderer lr;
    private Vector3 mousePos;
    private Vector3 startingPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.positionCount = 2;

        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0)){
            if(lr == null){
                lr = gameObject.AddComponent<LineRenderer>();
            }
            lr.enabled = true;
            startingPosition = player.position;
            
            lr.SetPosition(0, new Vector3(startingPosition.x, startingPosition.y, startingPosition.z));
            lr.useWorldSpace = true;
            lr.numCapVertices = 10;
        }
        if(Input.GetMouseButton(0)){
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            lr.SetPosition(1, new Vector3(mousePos.x, mousePos.y, mousePos.z));
            
        }
        if(Input.GetMouseButtonUp(0)){
            lr.enabled = false;
        }
    }
}
