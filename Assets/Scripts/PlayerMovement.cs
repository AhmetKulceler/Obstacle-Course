using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontalMovement;
    float verticalMovement;
    [SerializeField] float movementSpeed = 10.0f;

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        horizontalMovement = Input.GetAxis("Horizontal")  * movementSpeed * Time.deltaTime;
        verticalMovement = Input.GetAxis("Vertical")  * movementSpeed * Time.deltaTime;

        transform.Translate(horizontalMovement, 0, verticalMovement);
    }
}
