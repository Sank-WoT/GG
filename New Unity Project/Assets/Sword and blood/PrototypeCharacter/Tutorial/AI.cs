using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

	private Vector3 PosPlayer;
	private Vector3 PosMob;
	public float speed = 5;
	private GameObject mob;
	public GameObject player;
	 
	// Use this for initialization
	void Start () {
		mob = (GameObject)this.gameObject; 
	}
	
	// Update is called once per frame
	void Update () {
		PosPlayer = player.transform.position;
		PosMob=mob.transform.position;
		if (PosPlayer.z > PosMob.z) 
		{
						mob.transform.position += mob.transform.forward * speed * Time.deltaTime; 
		} 
		if (PosPlayer.z < PosMob.z)
		        {
						mob.transform.position -= mob.transform.forward * speed * Time.deltaTime; 
				}
		if (PosPlayer.z == PosMob.z)
		{
			mob.transform.position = mob.transform.position ; 
		}
	}
}


	