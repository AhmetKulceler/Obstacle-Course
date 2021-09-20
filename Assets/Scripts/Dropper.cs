using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5;
    private bool isTimePassed = false;

    MeshRenderer meshRenderer;
    Rigidbody rigidBody;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Time.time >= timeToWait && !isTimePassed)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;

            isTimePassed = true;
        }        
    }
}
