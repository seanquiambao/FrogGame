using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{


    private Rigidbody2D rb;
    private BoxCollider2D box2D;
    public int ForceMultiplier;

    
    private Vector2 distanceFromPlayer;
    private Vector2 mousePos;
    private bool playerJumping;

    public Camera cam;



    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }

    
    
    // Update is called once per frame
    void Update()
    {   

        if(Input.GetMouseButtonUp(0) && !playerJumping){
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            distanceFromPlayer =  mousePos - (Vector2)transform.position;
            Debug.Log("Mouse Position = " + mousePos);
            Launch(ForceMultiplier * -distanceFromPlayer);
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Platform"){
            playerJumping = false;
        }
    }
    void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.tag == "Platform"){
            playerJumping = true;
        }
    }

    public void Launch(Vector2 forceImpact){
        rb.AddForce(forceImpact, ForceMode2D.Impulse);
    }

    

}
