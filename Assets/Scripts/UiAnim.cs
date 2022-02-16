using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
public class UiAnim : MonoBehaviour
{
    [SerializeField] private TMP_Text _loseText;
    [SerializeField] private Button _button;

    public void AnimateUi()
    {
        _loseText.transform.DOLocalMoveY(250,1f).SetUpdate(true);
        _button.transform.DOScaleY(1, 1f).SetUpdate(true);
    }
}
