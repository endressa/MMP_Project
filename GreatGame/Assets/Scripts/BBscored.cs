using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BBscored : MonoBehaviour
{
    [SerializeField] private Transform ball;  //reference a ball
    [SerializeField] private Transform BBrespawnPoint;  //reference a respawnPoint

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ball")
        {
            //ball.transform.position = BBrespawnPoint.transform.position;
            Debug.Log("YOU WON !!!!");
        }
    }
}
