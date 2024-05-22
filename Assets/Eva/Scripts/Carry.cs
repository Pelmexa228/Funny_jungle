using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carry : MonoBehaviour
{
   
    void OnCollisionEnter(Collision col)
    {
        if (gameObject.CompareTag("Enemy"));
        Destroy(col.gameObject);
    }

    void 
       OnTriggerEnter(Collider col)
    {
        if (gameObject.CompareTag("Finish"));
        Destroy(col.gameObject);
    }
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"));
        Destroy(gameObject);
    }
    }
