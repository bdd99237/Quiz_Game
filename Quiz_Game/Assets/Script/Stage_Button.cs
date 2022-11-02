using UnityEngine;
using System.Collections;

public class Stage_Button : MonoBehaviour {

	public GameObject GM;

	public GameObject game_End;
	
	public string field_Select = "CommonSense";

	public int quiz_Level = 0;

	public bool multi_Choice = false;

	public int monster_Id_select = 0;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Game_End_window()
	{
		game_End.SetActive (true);
	}

	public void Continew()
	{
		game_End.SetActive (false);
	}

	public void Btn_Quit()
	{
		Application.Quit();
	}

	public void Score_Reset()
	{
		PlayerPrefs.DeleteKey ("BestScore");
		GM.GetComponent<GM> ().bestScore = 0;
		Debug.Log ("리셋되었습니다.");
	}

	public void Select_Stage()
	{
			Quiz_Search ();
			monster_search ();
	}

	void Quiz_Search()
	{
		GM.GetComponent<quiz_Class> ().choice_stage = true;
		GM.GetComponent<quiz_Class> ().selact_Quiz.quiz_Select = field_Select;
		GM.GetComponent<quiz_Class> ().selact_Quiz.quiz_Level = quiz_Level;
		GM.GetComponent<quiz_Class> ().selact_Quiz.multiple_Choice = multi_Choice;
	}
	
	void monster_search()
	{
			GM.GetComponent<monster_Class> ().Save_ID = monster_Id_select;
		GM.GetComponent<monster_Class> ().monster_create = true;
		}



	}