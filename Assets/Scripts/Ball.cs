using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

	public float speed;

	void Start () {
		// Sets ball initial speed
		impulseBall(Vector2.up);
	}

	// Calculates where ball collided on player
	float hitFactor(Vector2 ballPosition, Vector2 playerPosition, float barWidth) {
		return (ballPosition.x - playerPosition.x) / barWidth;
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player") {

			// Gets hit factor
			float x = hitFactor (transform.position, col.transform.position, col.collider.bounds.size.x);

			// Calculates direction
			Vector2 dir = new Vector2 (x, 1).normalized;

			impulseBall (dir);
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Finish") {
			SceneManager.LoadScene ("start-scene");
		}
	}

	void impulseBall(Vector2 direction) {
		GetComponent<Rigidbody2D> ().velocity = direction * speed;
	}
}
