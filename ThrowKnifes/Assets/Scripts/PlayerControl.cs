using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public int nn = 0;
    public HandControl hc;


    

    
    public float ypos;
    
    public bool isthrown = false;
    public bool collided = true;
    public int n = 0;

   

    private Vector2 startpos;
    void Start()
    {
        
        collided = true;
        startpos = transform.position;

    }

    /*private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("g1") || transform.rotation.z <= 0)
        {
            transform.RotateAround(target.transform.position, Vector3.forward, 40 * Time.deltaTime);
        }

        else if (collision.gameObject.CompareTag("g2"))
        {
            transform.RotateAround(target.transform.position, Vector3.back, 40 * Time.deltaTime);

        }
    }*/
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("border"))
        {
            collided = false;

        }


        if (collision.gameObject.CompareTag("a"))
        {
            collided = true;
        }


        if (collision.gameObject.CompareTag("b"))
        {
            
        }


    }
    
    



}
