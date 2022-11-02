using UnityEngine;
using System.Collections;

public class Monster
{
	public int monster_Id;
	public string monster_Name;
	public int monster_Current_HP;
	public int monster_Max_HP;
	public int monster_Resilience; //회복력
	public int monster_EXP;
	public int monster_Gold;
	public int monster_Image; //몬스터의 이미지파일이 들어갈 부분.
	public float monster_Time;
	public bool monster_Alive;
};

public class Monster_Manager: MonoBehaviour {
	public Monster[] Monster_Inpo = new Monster[20];

	// Use this for initialization
	void Start () {
		for (int i =0; i<20; i++) {
			Monster_Inpo[i] = new Monster();
		}

		Monster_Inpo [0].monster_Id = 1;
		Monster_Inpo [0].monster_Name = "monster_1";
		Monster_Inpo [0].monster_Current_HP = 300;
		Monster_Inpo [0].monster_Max_HP = 300;
		Monster_Inpo [0].monster_Resilience = 20;
		Monster_Inpo [0].monster_EXP = 10;
		Monster_Inpo [0].monster_Gold = 10;
		Monster_Inpo [0].monster_Image = 1;
		Monster_Inpo [0].monster_Time = 30;
		Monster_Inpo [0].monster_Alive = true;

		Monster_Inpo [1].monster_Id = 2;
		Monster_Inpo [1].monster_Name = "monster_2";
		Monster_Inpo [1].monster_Current_HP = 400;
		Monster_Inpo [1].monster_Max_HP = 400;
		Monster_Inpo [1].monster_Resilience = 30;
		Monster_Inpo [1].monster_EXP = 15;
		Monster_Inpo [1].monster_Gold = 15;
		Monster_Inpo [1].monster_Image = 2;
		Monster_Inpo [1].monster_Time = 40;
		Monster_Inpo [1].monster_Alive = true;

		Monster_Inpo [2].monster_Id = 3;
		Monster_Inpo [2].monster_Name = "monster_3";
		Monster_Inpo [2].monster_Current_HP = 500;
		Monster_Inpo [2].monster_Max_HP = 500;
		Monster_Inpo [2].monster_Resilience = 40;
		Monster_Inpo [2].monster_EXP = 20;
		Monster_Inpo [2].monster_Gold = 20;
		Monster_Inpo [2].monster_Image = 3;
		Monster_Inpo [2].monster_Time = 50;
		Monster_Inpo [2].monster_Alive = true;


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
