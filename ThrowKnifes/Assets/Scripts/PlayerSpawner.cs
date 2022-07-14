using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameOver GameOver;
    public Menu menu;
    public KnifeShowingEmpty kse;
    public Rigidbody2D rb;
    public GameObject player;
    public float y;
    public HandControl hc;
    public PrefabDestroy pd;
    public bool isspawned;
    public float curtime = 0;
    public float maxtime = 6;

    public int n = 10;

    void Start()
    {
        n = 10;
        GameObject knifeInstance = Instantiate(player);
        rb = knifeInstance.GetComponent<Rigidbody2D>();
        knifeInstance.transform.position = hc.gameObject.transform.position;
        knifeInstance.transform.parent = hc.gameObject.transform;
        Destroy(knifeInstance, 3f);
        isspawned = true;

        
    }
    
    private void Update()
    {


        if (curtime > maxtime && n != 0)
        {
            GameObject knifeInstance = Instantiate(player);
            rb = knifeInstance.GetComponent<Rigidbody2D>();
            knifeInstance.transform.parent = hc.gameObject.transform;
            knifeInstance.transform.position = hc.gameObject.transform.position;
            knifeInstance.transform.rotation = hc.gameObject.transform.rotation;


            
            curtime = 0;
            n--;
            kse.TextMesh.text = n.ToString();
            isspawned = true;
            Destroy(knifeInstance, 3f);

        }
        curtime += Time.deltaTime;


        if(curtime !> maxtime || n == 0)
        {
            isspawned = false;
        }

        if(n == 0)
        {
            GameOver.GameOveer();
        }
    }
}

