using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCheckpoint : Collectable
{
    public Animator animator;
    private string currentState;
    float animDelay;

    void start()
    {
        animator = GetComponent<Animator>();
    }

    void ChangeAnimationState(string newState)
    {
        //não permite que a animação interrompa a si mesma
        if (currentState == newState) return;

        //rodar animação
        animator.Play(newState);

        //mudar o estado
        currentState = newState;

        //pega a duração da animação
        animDelay = animator.GetCurrentAnimatorStateInfo(0).length;
        Debug.Log(animDelay);
        Debug.Log(currentState);
    }

    protected override void CollectableEffect()
    {
        GameController.Checkpoint = transform.position;
        ChangeAnimationState("CatA_Resgatado");
    }

}
