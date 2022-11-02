using UnityEngine;
using System.Collections;

public class battle : MonoBehaviour {

	public int battle_Mode = 0; //전투 중에 사용될 부분. 0시작, 1전투, 2상자보상 3종료
	public int quiz_Count = 0;
	[SerializeField]
	int quiz_Limit = 0; //외부에서 퀴즈 수 제한. 퀴즈를 연속으로 내고 일정량 해결시 나가기위한 일시적 사용
	public quiz_Class class_Quiz; //quiz_Class
	public TextMesh[] quiz_Text = new TextMesh[5]; //문제와 선택지를 받을
	public TextMesh display_time;
	bool mode_Active = false; //전투모드가 적용되고 진행중인지 확인

	[SerializeField]
	GameObject choice;
	[SerializeField]
	GameObject OX;

	public bool attak_Control =  false; //문제를 맞췄을때 공격을 한번만 시행하도록함.

	public GameObject GM;


	public TextMesh text_bar;
	public TextMesh Score_Text;

	bool choiceChange = false;

	float limit_Time = 0f;
	float save_Time = 0f;
	float count_dawn = 0f;

	[SerializeField]
	GameObject start_text;
	float start_TimeStart = 0;
	float start_TimeEnd = 5;

	float end_TimeStart = 0;
	float end_TimeEnd = 5;

	float fail_TimeStart = 0;
	float fail_TimeEnd = 5;

	[SerializeField]
	GameObject end_text;
	[SerializeField]
	GameObject box;
	[SerializeField]
	GameObject fail_text;

	[SerializeField]
	GameObject Time_bar; //
	float Time_Scale = 0;

	Vector2 mouse_position;

	Vector2 ray;
	RaycastHit2D hit;
	[SerializeField]
	Transform bom;

	[SerializeField]
	GameObject monster_switch; //몬스터의 이미지를 온오프


	public TextMesh pickUp_text;
	
	public TextMesh quiz_count_text;

	[SerializeField]
	GameObject quiz_result;
	[SerializeField]
	TextMesh re_Answer;
	[SerializeField]
	TextMesh re_wrong;

	int min_text;
	int sec_text;

	// Use this for initialization
	void Start () {
		Battle_Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		if (battle_Mode == 0) {
			Battle_Stert ();
		}

		if (battle_Mode == 1 && mode_Active == true) {
			Quiz_questions ();
			limit_Time = GM.GetComponent<monster_Class> ().CurrentMonster.monster_Time;
			save_Time += Time.deltaTime;
			count_dawn = limit_Time - save_Time;
			min_text = (int)count_dawn / 60;
			sec_text = (int)count_dawn % 60;
			display_time.text = string.Format("{0:D2}", min_text) + ":" + string.Format("{0:D2}", sec_text);;

			if (quiz_Count < quiz_Limit) {
				quiz_count_text.text = (quiz_Count + 1) + " / " + quiz_Limit;
			}

			if (attak_Control == true) {
				if (GM.GetComponent<GM> ().discern == false) {
					GM.GetComponent<GM>().wrong += 1;

				} else if (GM.GetComponent<GM> ().discern == true) {
					GM.GetComponent<GM> ().combo += 1;
					GM.GetComponent<GM> ().score += class_Quiz.current_Quiz.score;
				}
				GM.GetComponent<GM> ().score_n_combo_Renewal ();
				attak_Control = false;
			}
			Time_Scale = count_dawn / (limit_Time * 0.01f);
			Time_bar.GetComponent<Transform> ().localScale = new Vector3 (Time_Scale, 1, 1);

			if (save_Time >= limit_Time || quiz_Count >= quiz_Limit) {
				count_dawn = 0;
				display_time.text = string.Format("{0:D2}", min_text) + ":" + string.Format("{0:D2}", sec_text);;
				battle_Mode = 2;
				mode_Active = false;
			}
		}

		if (battle_Mode == 2) {
			GM.GetComponent<GM> ().Score_Save ();
			if (GM.GetComponent<GM> ().window_active == true) {
				if (Input.GetMouseButtonUp (0)) {
					ray = Camera.main.ScreenToWorldPoint (Input.mousePosition);
					hit = Physics2D.Raycast (ray, Vector2.zero);
					if (hit.collider != null) {
						if (hit.collider.gameObject.tag == "score_UI") {
							hit.collider.gameObject.SetActive (false);
							GM.GetComponent<GM> ().window_active = false;
							battle_Mode = 3;
						}
					}
				}
			} else {
				battle_Mode = 3;
			}
		}

		if (battle_Mode == 3) {
			quiz_result.SetActive (true);
			re_Answer.text = "맞은 갯수 : " + GM.GetComponent<GM> ().combo;
			re_wrong.text = "틀린 갯수 : " + GM.GetComponent<GM> ().wrong;
			/*
			if (Input.GetMouseButtonDown (0)) {
				ray = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				hit = Physics2D.Raycast (ray, Vector2.zero);
				if (hit.collider != null) {
					if (hit.collider.gameObject.tag == "resualt") {
						hit.collider.gameObject.SetActive (false);
						battle_Mode = 4;
					}
				}
			}
			*/
			battle_Mode = 4;
		}

		/*
		if (battle_Mode == 4) {
			GM.GetComponent<GM> ().Score_Reset ();
			Battle_End ();
		}
		*/
		if (battle_Mode == 4) {
			GM.GetComponent<GM> ().Score_Reset ();
		}
	}
	
	void Quiz_questions()
	{
		choiceChange = class_Quiz.current_Quiz.multiple_Choice;

		Change(choiceChange);

		//quiz_Text [0].text = class_Quiz.current_Quiz.question;

		if (choiceChange == true) {
			for (int i = 1; i<5; i++) {
				quiz_Text [i].text = class_Quiz.current_Quiz.choice [i - 1];
			}
		} else {

		}
		Score_Text.text = class_Quiz.current_Quiz.score + "점";
	}

	void Battle_Reset()
	{
		mode_Active = false;
		battle_Mode = 0;
		save_Time = 0;
		quiz_Count = 0;
		GM.GetComponent<monster_Class> ().CurrentMonster.monster_Alive = true;
		Time_bar.GetComponent<Transform> ().localScale = new Vector3 (100, 1, 1);
	}

	void Battle_Stert()
	{
		start_text.SetActive (true);
		start_TimeStart += Time.deltaTime;
		if (start_TimeStart >= start_TimeEnd) {
			start_text.SetActive(false);
			start_TimeStart = 0;
			battle_Mode = 1;
			mode_Active = true;
		}
	}

	public void Battle_End()
	{
			class_Quiz.Quiz_LineUP_Reset ();
			Battle_Reset();
			mode_Active = false;
			GM.GetComponent<GM>().display_Clear();
			class_Quiz.stage_Change = false;
	}
	
	void Mode_Dice(int min, int max)
	{
		battle_Mode	= Random.Range(min, max+1); //range는 min~max-1까지중 랜덤을 돌리므로 Max+1 ㅇㅇ?
		mode_Active = true;
	}

	//보기를 전환하기 위한 함수
	void Change(bool change)
	{
		choice.SetActive (change);
		OX.SetActive (!change);
	}
}