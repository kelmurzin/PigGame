using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Ufo : MonoBehaviour
{
    [SerializeField] private Transform[] _transform;
    [SerializeField] private Transform _transformExit;
    [SerializeField] private float _timeAction;
    [SerializeField] private float _timeNextAction;
    [SerializeField] private GameObject[] Item;

    private void Start() => StartCoroutine(UfoMove());

    private IEnumerator UfoMove()
    {
        while (true)
        {
            Transform spawn = _transform[Random.Range(0, _transform.Length)];
            GameObject randomprefab = Item[Random.Range(0, Item.Length)];

            yield return new WaitForSeconds(1f);
            transform.DOMove(spawn.position, _timeAction);
            yield return new WaitForSeconds(_timeAction);
            Instantiate(randomprefab, spawn.position, Quaternion.identity);
            yield return new WaitForSeconds(_timeNextAction);
            transform.DOMove(_transformExit.position, _timeNextAction);
            yield return new WaitForSeconds(8f);
        }
    }
}
