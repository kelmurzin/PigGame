using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Player : MonoBehaviour,IDamageble
{
    public event Action OnHealthChanged;

    public void TakeDamage()
    {
        OnHealthChanged?.Invoke();
    }

    
}
