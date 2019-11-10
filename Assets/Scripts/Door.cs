using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject alcohol;
    public GameObject enemy;
   
    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Player") && alcohol.activeSelf == false && enemy.activeSelf == false)
        {
            
            Destroy(gameObject);
        }
    }
}
