using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){    //"Collider other" registers when another GameObject has contact with the DeathZone
        Destroy(other.gameObject);
    }
}
