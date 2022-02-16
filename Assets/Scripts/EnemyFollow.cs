using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyFollow : EnemyAnim, IDamageble
{
    public bool Active;

    protected NavMeshAgent _agent;
    private GameObject _player;  
    
    [SerializeField] private RandomPointOnNavMesh _randomPointNavMesh;    
    [SerializeField] private TriggerObserver _triggerObserver;

    public void TakeDamage()
    {
        _animEnemy = AnimateEnemy.Dirty;
    }

    private void Start()
    {
        _triggerObserver.TriggerEnter += TriggerEnter;
        _triggerObserver.TriggerExit += TriggerExit;
        _player = GameObject.Find("Player");
        _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;
        Active = true;
    }
    private void TriggerEnter(Collider2D obj)
    {
        _randomPointNavMesh.enabled = false;
        Active = false;
        _animEnemy = AnimateEnemy.Angry;
    }
    private void TriggerExit(Collider2D obj)
    {
        _randomPointNavMesh.enabled = true;
        Active = true;
        _animEnemy = AnimateEnemy.Movement;
    }

    private void Update()
    {        
        if (Active)
            AgentFollowRandomPoint(_randomPointNavMesh.point);
           else
            UpdateTransformFollow(_player.transform);            
         
        UpdateAnim();
    }

    private void AgentFollowRandomPoint(Vector2 point)
    {
        _agent.SetDestination(point);
    }

    private void UpdateTransformFollow(Transform point)
    {
        movement = (point.transform.position - _agent.transform.position);
        _agent.SetDestination(point.position);
    }

    
}
