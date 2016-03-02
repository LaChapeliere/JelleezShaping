using UnityEngine;
using System.Collections;
using Fungus;

public class StillBehaviour : StateMachineBehaviour {

	public float deltaX = 0.01f;

	// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		Fungus.iTween.ShakeScale(animator.gameObject, Fungus.iTween.Hash("x", this.deltaX, "time", 1, "looptype", "Loop"));
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		Fungus.iTween.ShakeScale(animator.gameObject, Fungus.iTween.Hash("x", 0, "time", 0));
	}
}
