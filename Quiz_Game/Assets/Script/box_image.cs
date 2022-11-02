using UnityEngine;
using System.Collections;

public class box_image : MonoBehaviour {
	public Sprite box_Images =  new Sprite();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<SpriteRenderer> ().sprite = box_Images;
		
	}
}
