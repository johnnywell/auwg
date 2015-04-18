using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum gunTypes{

	NULL,
	CONTATO,
	ALCANCE,
	ALCANCEUNICO,
	ESPECIAIS

};

[System.Serializable]
public class GunBase{

	public string name;
	public gunTypes type;
	public int damage;
	public GameObject gunPrefab;
	
}

