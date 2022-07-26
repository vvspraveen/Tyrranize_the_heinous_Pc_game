using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMonitor : MonoBehaviour {
	
	public GameObject Health05;
	public GameObject Health04;
	public GameObject Health03;
	public GameObject Health02;
	public GameObject Health01;
	public int CurrentHealth;
	
	void Update () {
		CurrentHealth = GlobalHealth.PlayerHealth;
		
		if (CurrentHealth ==80  ) {
			if (Health05.transform.localScale.x <= 0.0f) {
				Health05.SetActive (false);
				Destroy(Health05);

			} else{
				Health05.transform.localScale -= new Vector3 (0.05f, 0.05f, 0.05f);
				Destroy(Health05);

			}
			
		}
		
		if (CurrentHealth == 60 ) {
			if (Health04.transform.localScale.x <= 0.0f) {
				Health04.SetActive (false);
				Destroy(Health04);
			} else {
				Health04.transform.localScale -= new Vector3 (0.05f, 0.0f, 0.0f);
				Destroy(Health04);
			}
			
		}
		
		if (CurrentHealth == 40) {
			if (Health03.transform.localScale.x <= 0.0f) {
				Health03.SetActive (false);
				Destroy(Health03);
			} else {
				Health03.transform.localScale -= new Vector3 (0.05f, 0.0f, 0.0f);
				Destroy(Health03);
			}
			
		}
		
		if (CurrentHealth == 20) {
			if (Health02.transform.localScale.x <= 0.0f) {
				Health02.SetActive (false);
				Destroy(Health02);
			} else {
				Health02.transform.localScale -= new Vector3 (0.05f, 0.0f, 0.0f);
				Destroy(Health02);
			}
			
		}
		
		if (CurrentHealth == 00) {
			if (Health01.transform.localScale.x <= 0.0f) {
				Health01.SetActive (false);
				Destroy(Health01);
			} else {
				Health01.transform.localScale -= new Vector3 (0.05f, 0.0f, 0.0f);
				Destroy(Health01);
			}
			
		}
		
		
	}
}