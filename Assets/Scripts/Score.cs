using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public static Score instance;

    [SerializeField] private TMP_Text _textScore;    
    private  int _score;

    public void UpdateScore(int point)
    {
        _score += point;
        _textScore.text = "Score: " + _score;
    }

    private void Awake() => instance = this;

    private void Start() => _textScore.text = "Score: " + _score;





}
