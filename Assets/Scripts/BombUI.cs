using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BombUI : MonoBehaviour
{
    public static BombUI instance;
    public int _bombScore;

    [SerializeField] private TMP_Text _bombText;

    public void UpdateBombScore() => _bombText.text = _bombScore.ToString();

    private void Awake() => instance = this;

    private void Start() => _bombText.text = _bombScore.ToString();
}
