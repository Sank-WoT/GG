
using UnityEngine;
using System.Collections;

public class Haracteristic : MonoBehaviour {
	public float Health;
	public float Mana;
	public float Speed; 
	public float Armor;
	public float MaxHealth;
	public float MaxMana;
	
	// Use this for initialization
	void Start () {
		Health = MaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0)
		{
			Debug.Log("Kill");
			//Destroy(gameObject);//прописать окончание игры
		}
	}
}
