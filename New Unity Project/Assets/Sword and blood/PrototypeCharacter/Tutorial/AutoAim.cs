/*using UnityEngine;
using System.Collections.Generic;
using FPSCTP;

public class AutoAim : MonoBehaviour
{
	Vector3 nearestAim = Vector3.zero;
	Vector3 dir, bestDir, enPos;
	Transform myTransform;
	float nearestAngle = 0;
	public float MaxDistance = 35;
	public float MinDistance = 0;
	float distance = 0;
	public float MaxAngle = 10f;
	public float maxDegreesDelta = 3f;

	void Start ()
	{
		myTransform = MainCharacter.MAIN_CHARACTER.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (OwnMouseLook.time > 0f) 
		{
			nearestAngle = 90;
	
			foreach (GenericEnemy enemy in GenericEnemy.enemyList) 
			{
				bestDir = Vector3.zero;
				if (!enemy.GetDead ()) {

					enPos = enemy.myTransform.position;
					enPos.y += 1.3f;
					dir = enPos - myTransform.position;
					distance = Vector3.Distance (myTransform.position, enPos);
					if (distance < MaxDistance && distance > MinDistance) {
						if (nearestAngle > Vector3.Angle (myTransform.forward, dir)) 
						{
							nearestAngle = Vector3.Angle (myTransform.forward, dir);
							bestDir = dir;
						}

					}

				}
				if (Vector3.Magnitude (bestDir) > 0.01f && nearestAngle < MaxAngle) 
				{
					myTransform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.LookRotation (bestDir), maxDegreesDelta);
				}


			}
		}

	


	}
}*/
