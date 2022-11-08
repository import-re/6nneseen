using UnityEngine;

public class introBehaviour : StateMachineBehaviour
{
    private int rand;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rand = Random.Range(0,2); //2 is not included
        if (rand == 0)
        {
            animator.SetTrigger("idle");
            
        }
        else
        {
            animator.SetTrigger("attack");
        }
    }
}
