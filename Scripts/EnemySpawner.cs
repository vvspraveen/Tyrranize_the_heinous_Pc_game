using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	// Use this for initialization
	public GameObject ZombieEnemyPrefab;

	[HideInInspector] public Transform[] enemySpawnPoints;

	public float spawnDuration =30f;

	void Start()
	{
		enemySpawnPoints = new Transform[transform.childCount];

		for(int i=0;i< transform.childCount; i++)
		{
			enemySpawnPoints[i]=transform.GetChild(i);
		}
		StartCoroutine (CoStartSpawning ());
	}

	IEnumerator CoStartSpawning() {
		while(true)
		{
			for(int i=0;i<enemySpawnPoints.Length;i++)
		{
			Transform enemySpawnPoint = enemySpawnPoints[i];
			Instantiate(ZombieEnemyPrefab, enemySpawnPoint.position, enemySpawnPoint.rotation);
		}
		yield return new WaitForSeconds (spawnDuration);
	}
}
}

