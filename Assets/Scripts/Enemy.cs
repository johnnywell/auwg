using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour {

	public ZombiesBase attributes;
	public Lis
	// Use this for initialization
	void Start () {

		startZombie();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startZombie(){
		int rand = Random.Range(0,3);

		switch(rand){
		case 0:
			attributes = new ZombiesBase(zombieTypes.FASTER ,100, 3, 10);

			break;
		case 1:
			attributes = new ZombiesBase(zombieTypes.BASIC ,100, 10, 5);

			break;
		case 2:
			attributes = new ZombiesBase(zombieTypes.TANKER ,500, 5, 3);
			break;
		}

	}
}
