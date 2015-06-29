using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour 
{
	public GameObject camere;
	public GameObject music;
	private  bool pause = false;
	public GameObject Player;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	if (Input.GetKeyDown (KeyCode.Pause)) 
		{
		if(pause == false)
			{
				Time.timeScale = 0;
				pause = true;
				(camere.GetComponent<Camera>() as Camera).enabled = false;
				MouseLook ml = (MouseLook) Player.GetComponent<MouseLook>();
			    ml.enabled = false;
			}
			else
			{
				Time.timeScale = 1;
				pause = false;
				(camere.GetComponent<Camera>() as Camera).enabled = true;
				MouseLook ml = (MouseLook) Player.GetComponent<MouseLook>();
				ml.enabled = true;
			}
		}
	}
}
