using UnityEngine;
using System.Collections;

public class quiz_image : MonoBehaviour {

	public Sprite[] quiz_Images =  new Sprite[10];
	
	public int Image_num;
	
	public GameObject GM;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Image_num = GM.GetComponent<quiz_Class> ().current_Quiz.quiz_Id;
		gameObject.GetComponent<SpriteRenderer> ().sprite = quiz_Images [Image_num-1];
	}
}
