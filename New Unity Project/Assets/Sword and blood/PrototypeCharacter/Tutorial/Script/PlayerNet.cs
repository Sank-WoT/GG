using UnityEngine;
using System.Collections;

public class PlayerNet : MonoBehaviour 
{
	private     NetworkView nView; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!nView.isMine)
		{
			GetComponent<MouseLook>().enabled = false;
		}

	}
}
