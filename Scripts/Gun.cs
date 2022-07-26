using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
	public ParticleSystem Muzzleflash;

	void Update () {
		if(Input.GetButtonDown("Fire1"))
		{
			Shoot();
	}
}
	void Shoot()
	{
		Muzzleflash.Play();
	}
}