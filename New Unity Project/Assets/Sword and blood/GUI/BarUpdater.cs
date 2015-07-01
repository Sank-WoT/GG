using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarUpdater : MonoBehaviour 
{
	public GameObject TargetBar;
	public GameObject TargetPlayer;
	public string TargetData;
	
	// Use this for initialization
	void Start () 
	{
		if (TargetData == "Health") 
		{
			TargetBar.GetComponent<Slider> ().maxValue = TargetPlayer.GetComponent<Haracteristic> ().MaxHealth;
		} 
		else if (TargetData == "Mana") 
		{
			TargetBar.GetComponent<Slider> ().maxValue = TargetPlayer.GetComponent<Haracteristic> ().MaxMana;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (TargetData == "Health") 
		{
				TargetBar.GetComponent<Slider> ().value = TargetPlayer.GetComponent<Haracteristic> ().Health;
		} 
		else if (TargetData == "Mana") 
		{
			TargetBar.GetComponent<Slider> ().value = TargetPlayer.GetComponent<Haracteristic> ().Mana;
		}
	}
}

