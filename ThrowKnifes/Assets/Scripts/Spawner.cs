using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fruit;
    public PlayerSpawner ps;
    public float height;
    public float width;
    public PlayerControl pc;
    
    void Start()
    {
        GameObject fruitInstance = Instantiate(fruit);
        fruitInstance.transform.position = new Vector2(Random.Range(-width, width), Random.Range(-height, height));
        pc.isthrown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pc.isthrown == true && ps.isspawned == false)
        {
            GameObject fruitInstance = Instantiate(fruit);
            fruitInstance.transform.position = new Vector2(Random.Range(-width, width), Random.Range(-height, height));
            GameObject fruitInstance2 = Instantiate(fruit);
            fruitInstance2.transform.position = new Vector2(Random.Range(-width, width), Random.Range(-height, height));
            pc.isthrown = false;
        }
    }
}
