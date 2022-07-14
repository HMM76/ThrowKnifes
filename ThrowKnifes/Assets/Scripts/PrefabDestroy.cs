using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDestroy : MonoBehaviour
{


    private void Start()
    {
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        


        if (collision.gameObject.CompareTag("border"))
        {
            
            Destroy(gameObject, 0.5f);
        }
    }

   
}
