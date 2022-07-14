using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TouchingItem : MonoBehaviour
{
    private PlayerSpawner ps;
    private PointTextReference ptf;
    public int n = 0;
    private ScoreAdding sa;

    private void Start()
    {
        sa = GameObject.FindWithTag("uimanager").GetComponent<ScoreAdding>();
        //ps = GameObject.FindWithTag("Player").GetComponent<PlayerSpawner>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            sa.AddPoints();
            //for adding additional daggers for colliding with fruits
            //ps.n++;
            Destroy(gameObject);
            //cwp.isbordered = 2;
        }
    }
}
