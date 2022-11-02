using UnityEngine;
using System.Collections;

public class quiz_Class : MonoBehaviour {
	public Quiz selact_Quiz = new Quiz (); //제출할 퀴즈의 조건을 가진부분
	public Quiz current_Quiz = new Quiz(); //제출할 퀴즈를 받을

	public bool choice_stage = false; //스테이지가 선택되었는가.
	public bool stage_Change = false; //스테이지와 배틀간의 화면 교체
	bool save_right = false; //정답을 맞췄을때를 체크

	[SerializeField]
	GameObject battleSeen;
	[SerializeField]
	GameObject stageSeen;

	bool quiz_Overlap =  false;

	string save_string;
	int save_int;
	bool save_bool;
	public int[] select_Quiz_Id = new int[50]; //조건에 부합한 문제들의 ID를 저장하는 부분
	int[] used_Quiz_Id = new int[50]; //사용된 문제들의 ID를 저장.
	int used_count = 0;

	int count = 0; //선택된 조건에 맞는 문제의 수
	int count2 = 0; //조건에 맞는 문제 중 하나를 선택
	public int select_id = 0; //문제를 내기 위해 최종 선택된 문제의 아이디

	public GameObject Quiz_db;

	// Use this for initialization
	void Start () {
		Quiz_Reset ();
		Quiz_LineUP_Reset ();
	}

	// Update is called once per frame
	void Update () {
		if (choice_stage == true) {
			stage_Change = true;
			Seen_Change(stage_Change);
			Quiz_Load ();
			Quiz_Output();
			choice_stage = false;
		}

		save_right = GetComponent<GM> ().check_right;

		if (save_right == true) {
			//Quiz_Reset();

		}
		if (save_right == false) {
			Seen_Change(stage_Change);

		}



	}

	void Quiz_Load()
	{
		for (int i = 0; i<50; i++) {
			if (i == 0) {
				count = 0;
			}
			save_string = Quiz_db.GetComponent<Quiz_Manager> ().my_Quiz [i].quiz_Select;
			save_int = Quiz_db.GetComponent<Quiz_Manager> ().my_Quiz [i].quiz_Level;
			save_bool = Quiz_db.GetComponent<Quiz_Manager> ().my_Quiz [i].multiple_Choice;
			if (save_string == selact_Quiz.quiz_Select && save_int == selact_Quiz.quiz_Level && save_bool == selact_Quiz.multiple_Choice) {
				select_Quiz_Id [count] = i + 1;
				count += 1;
			}
		}
	}
	
	public void Quiz_Output()
	{
		count2 = Random.Range (0, count);
		Debug.Log (count2);
		select_id = select_Quiz_Id [count2];

		for (int i = 0; i<50; i++) {
			if(used_Quiz_Id[i] == select_id)
			{
				quiz_Overlap = true;
			}
		}
		if (!quiz_Overlap) {
			current_Quiz = Quiz_db.GetComponent<Quiz_Manager> ().my_Quiz [select_id - 1];
			used_Quiz_Id [used_count] = select_id;
			used_count += 1;
		} else {
			quiz_Overlap = false;
			Quiz_Output();
		}
	}

	void Quiz_Reset()
	{
		current_Quiz = new Quiz ();
	}

	public void Quiz_LineUP_Reset()
	{
		for(int i = 0; i<50;i++)
		{
			select_Quiz_Id[i] = new int();
			used_Quiz_Id[i] = new int();
		}
		used_count = 0;
	}

	void Seen_Change(bool change)
	{
		battleSeen.SetActive (change);
		stageSeen.SetActive (!change);
	}
}