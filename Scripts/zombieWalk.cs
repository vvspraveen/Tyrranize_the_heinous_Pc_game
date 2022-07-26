using UnityEngine;
using System.Collections;

public class zombieWalk : MonoBehaviour {
	protected Animator myAnimation;
	
	void Start () {
		myAnimation = GetComponent<Animator> ();
	}
	
	void Update () {
		myAnimation.SetFloat ("speed", Input.GetAxis ("Vertical"));
	}
}
