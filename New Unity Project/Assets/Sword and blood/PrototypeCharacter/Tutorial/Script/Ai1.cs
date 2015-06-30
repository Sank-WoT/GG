using UnityEngine;
using System.Collections;
public class Ai1 : MonoBehaviour 
{
	GameObject target; 
	void Start ()
	{
		target = GameObject.FindGameObjectWithTag("Player");
	} 
	void Update ()
	{
		//Устанавливаем новую позицию
		transform.position = Vector3.Slerp (this.transform.position, target.transform.position, 1 * Time.deltaTime);
	}
}