using UnityEngine;
using System.Collections;

public class Ai1 : MonoBehaviour 
{
	//Цель (пункт Б)
	private GameObject mob;
	public GameObject player;
	public int Delay;
	//Стартовая позиция
	private Vector3 _startPos;
	//Конечная позиция
	private Vector3 _endPos;
	// Use this for initialization
	void Start ()
	{
		mob = (GameObject)this.gameObject; 

		//Запоминаем начальную и конечную позиции
		_startPos = mob.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		_endPos = player.transform.position;
		//Устанавливаем новую позицию
		transform.position = Vector3.Slerp(_startPos, _endPos, Time.time/Delay);
	}
}