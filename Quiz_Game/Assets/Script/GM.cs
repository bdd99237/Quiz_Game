using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

	public int check_number; //내가 선택한 선택지
	public int right_answer;//지정된 정답
	public GameObject right_Answer_Text; //정답시 화면에 표시할 텍스트
	public GameObject wrong_Answer_Text; //오답일때 나타낼 텍스트
	bool text_Swith = false; //텍스트의 활성/비활성을 제어
	float swithing_Time = 0f; //텍스트활성화 후 시간을 센다.
	[HideInInspector]
	public bool check_right = false; //답이 들어왔는가.
	[HideInInspector]
	public bool discern = false;
	public GameObject battle_seen;

	public int combo = 0; //문제를 연속으로 맞춘수
	public int wrong = 0;
	public int score = 0; //점수를 저장할 부분
	public int bestScore = 0; //최고점수

	[SerializeField]
	GameObject best_Score_Window;
	[SerializeField]
	TextMesh best_Score_Text;
	[SerializeField]
	TextMesh score_Text;
	[SerializeField]
	TextMesh combo_Text;


	[SerializeField]
	TextMesh hart_Time_Text; //텍스트
	//float hart_time = 0; //시간저장부분
	//float max_Hart_Time = 300; //쿨타임
	float count_time;//남은시간


	public bool window_active = false;

	void Awake()
	{
		if (PlayerPrefs.HasKey ("BestScore")) {
			bestScore = PlayerPrefs.GetInt("BestScore");
		}

	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		right_answer = gameObject.GetComponent<quiz_Class> ().current_Quiz.Choice_Answer;

		if (check_right == true) {
			check_number = 0;
			swithing_Time += Time.fixedDeltaTime;
			if (swithing_Time >= 1.0f) {
				Clear_Text ();
				swithing_Time = 0f;
				gameObject.GetComponent<quiz_Class> ().Quiz_Output ();
				battle_seen.GetComponent<battle> ().quiz_Count += 1;
			}
		}

		if (check_number != 0) {
			if (check_number == right_answer) {
				right_Answer_Text.SetActive (true);
				discern = true;
			} else {
				if (!check_right) {
					wrong_Answer_Text.SetActive (true);
					discern = false;
				}
			}
			check_right = true;
			battle_seen.GetComponent<battle> ().attak_Control = true;
		}
		/*
		if (gameObject.GetComponent<Stage> ().player.Hart < 5) {

			hart_Timer();

		}
		*/
	}

	void Clear_Text()
	{
		check_right = false;
		right_Answer_Text.SetActive(false);
		wrong_Answer_Text.SetActive(false);
	}

	public void Score_Save()
	{
		if (bestScore < score) {
			bestScore = score;
			Best_Score_Set ();
			PlayerPrefs.SetInt ("BestScore", bestScore);
			PlayerPrefs.Save ();
			window_active = true;
		}
	}

	public void Score_Reset()
	{
		combo = 0;
		wrong = 0;
		score = 0;
	}

	public void Best_Score_Set()
	{
		best_Score_Text.text = bestScore + "!!!";
		best_Score_Window.SetActive (true);
		}

	public void score_n_combo_Renewal()
	{
		score_Text.text = "SCORE : " + score;
		combo_Text.text = "정답 수 : " + combo;
	}
	/*
	void hart_Timer()
	{
		hart_time += Time.deltaTime;
		count_time = max_Hart_Time - hart_time;
		min_text = (int)count_time / 60;
		sec_text = (int)count_time % 60;
		hart_Time_Text.text = string.Format("{0:D2}", min_text) + ":" + string.Format("{0:D2}", sec_text);
		if (hart_time >= max_Hart_Time) {
			hart_time = 0;
			gameObject.GetComponent<Stage>().player.Hart += 1;
		}
		*/


	public void display_Clear()
	{
		score_Text.text = "";
		combo_Text.text = "";
		battle_seen.GetComponent<battle> ().display_time.text = "";
		//battle_seen.GetComponent<battle> ().pickUp_text.text = "";
		for (int i = 1; i<5; i++) {
			battle_seen.GetComponent<battle> ().quiz_Text [i].text = "";
		}
		battle_seen.GetComponent<battle> ().Score_Text.text = "";
		battle_seen.GetComponent<battle> ().quiz_count_text.text = "";

	}
}
