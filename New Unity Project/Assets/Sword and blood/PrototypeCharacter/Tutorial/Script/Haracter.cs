using UnityEngine;
using System.Collections;

public class Haracter : MonoBehaviour {
	public float Health;
	public float Mana;
	public float Speed; 
	public float Armor;
	public float MaxHealth;
	public float MaxMana; 
	public void Damage(float dmg) 
	{ 
		Health -= dmg; 
	}  
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Health<1) 
		{ 
			Destroy(gameObject);//Вместо этого надо будет придумать анимацию умирания
		} 
	}
}
