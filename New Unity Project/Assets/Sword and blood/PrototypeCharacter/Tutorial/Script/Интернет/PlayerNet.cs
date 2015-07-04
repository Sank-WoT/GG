
using UnityEngine;
using System.Collections;

public class PlayerNet : MonoBehaviour 
{
	public NetworkView nView; 
	
	// Use this for initialization
	void Start () {
		nView = GetComponent<NetworkView>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!nView.isMine)
		{
			GetComponent<MouseLook>().enabled = false;
		}
		
	}
}