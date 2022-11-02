using UnityEngine;
using System.Collections;

public class Choice_Button : MonoBehaviour {
	[SerializeField]
	GameObject GM;
	public int choice_number = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Choice_Retrun()
	{
		if (gameObject.GetComponentInParent<battle>().battle_Mode == 1) {
			GM.GetComponent<GM> ().check_number = choice_number;
		}
	}
}
