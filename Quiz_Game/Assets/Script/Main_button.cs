using UnityEngine;
using System.Collections;

public class Main_button : MonoBehaviour {

	[SerializeField]
	GameObject GM;

	[SerializeField]
	GameObject result;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Start_Stage()
	{
		Application.LoadLevel ("main_Scene");
		
	}

	public void Main_Back()
	{
		Application.LoadLevel ("farst_Scene");
	}

	public void result_home()
	{
		result.SetActive (false);
		gameObject.GetComponentInParent<battle> ().Battle_End ();
	}

	public void ReGame()
	{
		result.SetActive (false);
		gameObject.GetComponentInParent<battle> ().Battle_End ();
		GM.GetComponent<quiz_Class> ().choice_stage = true;
	}

	public void NextStage()
	{
		result.SetActive (false);
		gameObject.GetComponentInParent<battle> ().Battle_End ();
		//다음 스테이지 이동 하도록 해야함.
	}
}
