using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    //public GameObject alcohol;
    //public GameObject enemi;
    public bool alcohol3 = true;
    public bool enemi3 = true;
    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Player") && alcohol3 && enemi3)
        {
            
            Destroy(gameObject);
        }
    }
}
