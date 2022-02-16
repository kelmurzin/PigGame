using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TriggerObserver : MonoBehaviour
{
    public event Action<Collider2D> TriggerEnter;
    public event Action<Collider2D> TriggerExit;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        TriggerEnter?.Invoke(other);           
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.tag == "Player")
            TriggerExit?.Invoke(other);
    }      
   
}
