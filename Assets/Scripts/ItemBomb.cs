using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBomb : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            BombUI.instance._bombScore++;
            BombUI.instance.UpdateBombScore();
            
            Destroy(gameObject);
        }

        else if(other.gameObject.tag == "Dog")
          Destroy(gameObject);        
    }
}
