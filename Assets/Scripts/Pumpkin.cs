using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    [SerializeField] private int _point;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Score.instance.UpdateScore(_point);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Fermer")
            Destroy(gameObject);
        
    }
}
