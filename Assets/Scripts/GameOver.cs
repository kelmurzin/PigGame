using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{    
    [SerializeField] private HealthBarPlayer _hpPlayer;
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private UiAnim _uiAnim;

    private void Start()
    {
        _losePanel.SetActive(false);
        Time.timeScale = 1f;
    }
    private void OnEnable()
    {
        _hpPlayer.OnDie += LoseGame;
    }

    private void LoseGame()
    {
        _losePanel.SetActive(true);
        _uiAnim.AnimateUi();
        Time.timeScale = 0f;
    }

    private void OnDisable()
    {
        _hpPlayer.OnDie -= LoseGame;
    }
}
