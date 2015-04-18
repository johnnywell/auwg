using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerBehaviour : MonoBehaviour {

	private float h, v;
	public int hp;
	public List<GunBase> guns = new List<GunBase>();
	public GunBase currentGun, bagGun;
	public Transform gunPoint;

	// Use this for initialization
	void Start () {
		currentGun = guns[Random.Range(0,3)];
		GameObject aux = Instantiate(currentGun.gunPrefab, gunPoint.position, transform.rotation) as GameObject;
		aux.transform.SetParent(this.transform);
	}
	
	// Update is called once per frame
	void Update () {
		walk (5);


	}

	public void walk(int speed){
		h = Input.GetAxis("Horizontal");
		v = Input.GetAxis("Vertical");
		
		this.transform.Translate(new Vector3(h*Time.deltaTime*speed, 0, v*Time.deltaTime*speed));

	}
}
