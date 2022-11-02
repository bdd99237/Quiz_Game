using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class monster_image : MonoBehaviour {

	public Sprite[] monster_Images =  new Sprite[10];

	public int Image_num;

	public GameObject GM;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Image_num = GM.GetComponent<monster_Class> ().CurrentMonster.monster_Image;
		gameObject.GetComponent<SpriteRenderer> ().sprite = monster_Images [Image_num-1];

	}
}
