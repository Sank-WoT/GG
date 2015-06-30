
using UnityEngine;
using System.Collections;

public class Haracteristic : MonoBehaviour {
	public float Healt;
	public float Mana;
	public float Speed; 
	public float Armor;
	public float MaxHealt;
	public float MaxMana;
	
	// Use this for initialization
	void Start () {
		Healt = MaxHealt;
	}
	
	// Update is called once per frame
	void Update () {
		if (Healt <= 0)
		{
			Debug.Log("Kill");
			//Destroy(gameObject);//прописать окончание игры
		}
	}
}
