using UnityEngine;
using System.Collections;

public class ZombieSpawner : MonoBehaviour {
	public GameObject enemy;
	// Use this for initialization
	void Start () {
		InvokeRepeating("spawnEnemy", 2f, 4f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void spawnEnemy(){
		Instantiate(enemy, new Vector3(Random.Range(-7.4f, 0.3f), 1.25f, -2.36f) , new Quaternion(0, 0, 0, 0));
	}
	
}
