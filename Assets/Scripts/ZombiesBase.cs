using UnityEngine;
using System.Collections;

public enum zombieTypes{
	
	BASIC,
	TANKER,
	FASTER
	
};

[System.Serializable]
public class ZombiesBase {

	public zombieTypes type;
	public int hp, damage, speed;


	public ZombiesBase(){
		
	}

	public ZombiesBase(zombieTypes currentType, int health, int atack, int velocity){

		this.type = currentType;
		this.hp = health;
		this.damage = atack;
		this.speed = velocity;

	}

	public int getHP(){

		return this.hp;

	}
	public void setHP(int value){
		
		this.hp = value;
		
	}


}
