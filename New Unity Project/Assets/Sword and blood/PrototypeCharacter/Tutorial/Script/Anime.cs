using UnityEngine;
using System.Collections;

public class Anime : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("w")||Input.GetKeyDown ("s")||Input.GetKeyDown ("d")||Input.GetKeyDown ("a")) {GetComponent<Animation> ().CrossFade ("walk");}
		if (Input.GetKeyDown ("space")) {
						GetComponent<Animation> ().CrossFade ("jump_running");
				}
		if (Input.GetKeyDown(KeyCode.LeftShift)) {
						GetComponent<Animation> ().CrossFade ("run");
				}
	}
}
