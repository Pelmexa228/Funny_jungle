using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerzone : MonoBehaviour
{
    
    void OnCollisionEnter(Collision col)
    {
        //if (col.gameObject.name == "Cube") ;
        //Destroy(col.gameObject);

        if (col.gameObject.CompareTag("Enemy"))
            col.gameObject.transform.position = new Vector3(-10f, 1f, -15f);
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Finish"))
            col.gameObject.transform.position = new Vector3(-10f,1f,-15f);
    }
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"))
            col.gameObject.transform.position = new Vector3(-10f, 1f, -15f);
    }
    }
