using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picker : MonoBehaviour
{
    [Range(1,4)]public int numbObject;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }

    
}
