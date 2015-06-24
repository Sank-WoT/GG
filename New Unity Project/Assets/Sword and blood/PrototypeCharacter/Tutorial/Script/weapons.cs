using UnityEngine;
using System.Collections;
public class weapons : MonoBehaviour 
{
	// Use this for initialization
	void Start () {
	SelectWeapon(0);
	}
	
	// Update is called once per frame
	void Update () {
						if (Input.GetKeyDown ("1")) 
			            {
								SelectWeapon (0);
						} 
			            else if (Input.GetKeyDown ("2"))
			            {
								SelectWeapon (1);
						}

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
	