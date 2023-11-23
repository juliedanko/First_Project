using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    [Header("Animator variable names")]
    [SerializeField] private string walk;
    [SerializeField] private string attack, jumpAttack, die;
    [Header("Controls")]
    [SerializeField] private KeyCode walkKey;
    [SerializeField] private KeyCode attackKey, jumpAttackKey, dieKey;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKey(walkKey))
        {
            animator.SetBool(walk, true);
        }
        else
        {
            animator.SetBool(walk, false);
        }

        if(Input.GetKeyDown(attackKey))
        {
            animator.SetTrigger(attack);
        }
        if (Input.GetKeyDown(jumpAttackKey))
        {
            animator.SetTrigger(jumpAttack);
        }
        if (Input.GetKeyDown(dieKey))
        {
            animator.SetTrigger(die);
        }
    }
}
