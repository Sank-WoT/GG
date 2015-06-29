using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{
	public float time = 1;

	void Start () 
	{
		Destroy( gameObject, time );
	}

}