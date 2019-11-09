using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public GameObject target;


    Vector3 offset;

    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    private void FixedUpdate()
    {

        transform.position = target.transform.position + offset;
        transform.LookAt(target.transform.position);

    }
}
