using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score = 0;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Ground" && other.gameObject.tag != "Hit")
        {
            score += 1;
            Debug.Log("You have bumped into a thing " + score + " times.");
        }        
    }
}
