using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Movement
		float moveX = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
		transform.Translate (moveX, 0.0f, 0.0f);

		if (!hasBrick()) {
			SceneManager.LoadScene ("start-scene");
		}

	}

	public bool hasBrick() {
		int bricksInScene = GameObject.FindGameObjectsWithTag ("Brick").Length;
		return bricksInScene > 0;
	}
}
