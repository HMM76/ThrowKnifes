using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    
    public GameObject shootb;
    public PlayerControl pc;
    public PlayerSpawner ps;
    public bool shotb = true;
    public int f = 0;
    public float speed;
    private void Start()
    {
    }
    public void Shooot()
    {
        
        //if (shotb == true)
        //{
            //ash.gameObject.SetActive(true);
            f++;
        ps.rb.AddForce(speed * pc.transform.up, ForceMode2D.Impulse);
        
            pc.isthrown = true;
            pc.collided = false;
        //}
    }
}
