using UnityEngine;
using System.Collections;

public class monster_Class : MonoBehaviour {
	public int Save_ID = 0; 
	public Monster CurrentMonster = new Monster();
	public bool monster_create = false;
	// Use this for initialization
	void Start () {
		Reset ();


	}
	
	// Update is called once per frame
	void Update () {
		if (monster_create) {
			CreateMonster ();
			monster_create = false;
		}

	}

	public void CreateMonster()
	{
		for (int i = 0; i<20; i++) {
			if (gameObject.GetComponent<Monster_Manager> ().Monster_Inpo [i].monster_Id == Save_ID)
			{
				CurrentMonster = gameObject.GetComponent<Monster_Manager> ().Monster_Inpo [i];
			}
		}
	}

	public void Reset()
	{
		CurrentMonster = new Monster ();
		Save_ID = 0;
	}
}
