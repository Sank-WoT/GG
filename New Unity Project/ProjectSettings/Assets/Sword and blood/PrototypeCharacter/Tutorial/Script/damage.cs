using UnityEngine;
using System.Collections;

public class damage : MonoBehaviour {
	public float Damagepoint;
	public Haracter test;
	private int a;
	void OnCollisionEnter(Collision collision) 
	{ 
		collision.gameObject.SendMessage("Damage", Damagepoint); 
		Destroy(gameObject);
	
	} 
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
}