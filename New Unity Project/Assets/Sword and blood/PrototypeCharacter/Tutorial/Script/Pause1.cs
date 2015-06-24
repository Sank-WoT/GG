using UnityEngine;
using System.Collections;

public class GrafickPausa : MonoBehaviour {
	bool kn = false;
	public string effect1;
	public GameObject Player;
	public GameObject PlayerCamera;
	bool ln = true;
	public string effect2;
	public string tex;
	
	
	
	// Use this for initialization
	void OnGUI () {
		if(kn)
		{
			if(GUI.Button(new Rect(Screen.width/2,Screen.height/2,100,20),effect1))
			{
				PlayerCamera.GetComponent<SSAOEffect>().enabled = !PlayerCamera.GetComponent<SSAOEffect>().enabled;
			}
			if(GUI.Button(new Rect(Screen.width/2,Screen.height/2+30,100,20),effect2))
			{
				PlayerCamera.GetComponent<MotionBlur>().enabled = !PlayerCamera.GetComponent<MotionBlur>().enabled;
			}
			GUI.Label(new Rect(Screen.width/2,Screen.height/2-30,100,20),tex);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.F1))
		{
			kn = false;
			Time.timeScale = 1;
			MouseLook ml = (MouseLook) Player.GetComponent<MouseLook>();
			ml.enabled = true;
			MouseLook mf = (MouseLook) PlayerCamera.GetComponent<MouseLook>();
			mf.enabled = true;
			PlayerCamera.GetComponent<BlurEffect>().enabled = false;
		}
		if(ln)
		{
			if(Input.GetKeyDown(KeyCode.Escape))
			{
				MouseLook mf = (MouseLook) PlayerCamera.GetComponent<MouseLook>();
				mf.enabled = false;
				MouseLook ml = (MouseLook) Player.GetComponent<MouseLook>();
				ml.enabled = false;
				Time.timeScale = 0;
				kn = true;
				PlayerCamera.GetComponent<BlurEffect>().enabled = true;
				
			}
		}
		
		
	}
}