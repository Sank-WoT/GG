using UnityEngine;
using System.Collections;

public class Haracter : MonoBehaviour {
	public float Health;
	public float Mana;
	public float Speed; 
	public float Armor;
	public float MaxHealth;
	public float MaxMana; 
	public float Damag;//урон
	public float SpeedAttack = 1;// Скорость атаки
	private float t = 0;//Время
	GameObject P; 
	GameObject target; 
	float Har;
	public void Damage(float dmg) 
	{ 
		Health -= dmg; 
	}  
	// Use this for initialization
	void Start () 
	{
		target = GameObject.FindGameObjectWithTag("Player");// Нахождение объекта	Player
		P = GameObject.Find ("Player"); //Нахождение объекта	Player
	}
	
	// Update is called once per frame
	void Update () 
	{
		Har = Vector3.Distance (this.transform.position, target.transform.position);
		//Debug.Log(Har);
		if (Har < 5) 
		{	
						if (Time.time > t) 
			            {
				                Debug.Log("Attack");
				                t = Time.time + SpeedAttack ;
								P.GetComponent<Haracteristic> ().Healt -= Damag; // Обращение к переменной и ее изменение
						}
		}
		if(Health<1) 
		{ 
			Destroy(gameObject);//Вместо этого надо будет придумать анимацию умирания
		} 
	}
}

