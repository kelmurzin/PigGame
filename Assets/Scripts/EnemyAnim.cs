using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyAnim : MonoBehaviour
{    
    protected Vector2 movement;
    public  Animator animator;
   
    public enum AnimateEnemy
    {
        Movement, Dirty, Angry
    }
    public AnimateEnemy _animEnemy = AnimateEnemy.Movement;

    

    public void UpdateAnim()
    {
        switch (_animEnemy)
        {
            case AnimateEnemy.Movement:
                MovementAnim();
                break;
            case AnimateEnemy.Dirty:
                DirtyAnim();
                break;
            case AnimateEnemy.Angry:
                AngryAnim();
                break;
        }
    }

    private void DirtyAnim()
    {
        animator.Play("Dirty");
        animator.SetFloat("HorizontalDirty", movement.x);
        animator.SetFloat("VerticalDirty", movement.y);
    }
    private void AngryAnim()
    {
        animator.Play("Angry");
        animator.SetFloat("HorizontalAngry", movement.x);
        animator.SetFloat("VerticalAngry", movement.y);
    }
    private void MovementAnim()
    {
        animator.Play("Movement");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
    }
}
