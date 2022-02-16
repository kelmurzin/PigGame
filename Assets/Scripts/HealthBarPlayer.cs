using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class HealthBarPlayer : MonoBehaviour
{
    public event Action OnDie;

    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private Player _player;
    [SerializeField] private int _health;


    private void OnEnable()
    {
        _player.OnHealthChanged += HealthChange;
    }

    private void Start()
    {
        _healthText.text = _health.ToString();
    }

    private void HealthChange()
    { 
            _health -= 1;
            _healthText.text = _health.ToString();

        if (_health <= 0)
            OnDie?.Invoke();

    }

    private void OnDisable()
    {
        _player.OnHealthChanged -= HealthChange;
    }

}
