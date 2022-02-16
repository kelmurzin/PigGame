using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomPointOnNavMesh : MonoBehaviour
{
    public float range;
    public float time;
    
    public Vector3 point;    
    NavMeshHit hit;

    private void Start() => StartCoroutine(FindPoint());


    IEnumerator FindPoint()
    {

        while (true)
        {            
            NavMesh.SamplePosition(Random.insideUnitSphere * range, out hit, range, NavMesh.AllAreas);
            point = hit.position;           
            yield return new WaitForSeconds(time);
        }

    }
    
}
