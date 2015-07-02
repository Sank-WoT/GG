using UnityEngine;
using System.Collections;
public class weapons : MonoBehaviour 
{
	public GameObject Sword;
	public GameObject Bow;
	// Use this for initialization
	void Start () 
	{
	SelectWeapon(0);
	}
	
	// Update is called once per frame
	void Update () {
						if (Input.GetKeyDown ("1")) 
			            {
			Null();
			Bow.SetActive(true);
								SelectWeapon (0);
						} 
			            else if (Input.GetKeyDown ("2"))
			            {
			Null();
			Sword.SetActive(true);
								SelectWeapon (1);
						}

}
	void Null()
	{
		Bow.SetActive(false);
		Sword.SetActive(false);
	}
	void  SelectWeapon( int index)
	{
		for (int i=0;i < transform.childCount;i++) 
		{
			// Оператор "Если (i равно индексу) - то"
			if (i == index)
			{
				// Принимает значение за правду и оружие появляется.
				transform.GetChild(i).gameObject.SetActiveRecursively(true);
			}
			// Оператор "Иначе"
			else	
				// Принимает значение за ложь, и оружие пропадает.
				transform.GetChild(i).gameObject.SetActiveRecursively(false);
		}
	}
}
	