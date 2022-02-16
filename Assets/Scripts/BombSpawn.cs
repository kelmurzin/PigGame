using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _bomb;
  
    public void DropBomb()
    {
        if (BombUI.instance._bombScore > 0)
        {
            BombUI.instance._bombScore--;
            BombUI.instance.UpdateBombScore();
            Instantiate(_bomb, transform.position, Quaternion.identity);
        }
    }
}
