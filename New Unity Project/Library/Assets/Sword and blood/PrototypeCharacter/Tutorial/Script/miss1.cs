
using UnityEngine;
using System.Collections;


public class miss1 : MonoBehaviour
{
	public Rigidbody projectile;
	public float speed = 20;
	public float ammo = 100;
	public float timout = 0.5F;
	private float time = 0;
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			if(ammo > 0)
			{
				if(Time.time > time)
				{
				ammo--;
					time = Time.time + timout;
			Rigidbody instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation)as Rigidbody;
			instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,speed));
			//Physics.IgnoreCollision( instantiatedProjectile.GetComponent<Collider>(), transform.root.GetComponent<Collider>());
				}
				}
			}
		}
	}