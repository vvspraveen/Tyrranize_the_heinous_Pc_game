using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontrolscript : MonoBehaviour {

	public GameObject objectToDisable;
	public static bool disabled = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (disabled)
			objectToDisable.SetActive (true);
		else
			objectToDisable.SetActive (false);
	}
}