using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandControl : MonoBehaviour
{
    public bool collided = true;
    public float vector3;
    public GameObject target;

    private void Start()
    {
        vector3 = transform.rotation.z;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && collided == true)
        {
            transform.RotateAround(target.transform.position, Vector3.forward, 60 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) && collided == true)
        {
            transform.RotateAround(target.transform.position, Vector3.back, 60 * Time.deltaTime);

        }
    }
}
