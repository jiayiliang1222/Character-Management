using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceFinishedBehavior : StateMachineBehaviour
{
    int isDancingHash;

    private void Awake()
    {
        isDancingHash = Animator.StringToHash("IsDancing");
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("IsDancing", false);
    }

}
