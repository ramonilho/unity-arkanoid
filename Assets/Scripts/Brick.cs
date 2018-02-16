using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	bool isCracked;
	public Sprite crackedSprite;

	void OnCollisionEnter2D(Collision2D col) {

		if (isCracked) {
			Destroy (gameObject);
		} else {
			isCracked = true;

			SpriteRenderer renderer = GetComponent<SpriteRenderer> ();
			renderer.sprite = crackedSprite;
		}

	}
}
