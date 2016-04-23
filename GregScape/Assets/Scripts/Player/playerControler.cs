using UnityEngine;
using System.Collections;

public class playerControler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
	}

	void Movement () {

		Vector2 direction = new Vector2 ();

		if (Input.GetKey (KeyCode.D)) {
			direction.x += 1;
		}

		if (Input.GetKey (KeyCode.A)) {
			direction.x -= 1;
		}

		if (Input.GetKey (KeyCode.W)) {
			direction.y += 1;
		}

		if (Input.GetKey (KeyCode.S)) {
			direction.y -= 1;
		}

		direction.Normalize ();

		direction *= 0.1f;

		transform.position += new Vector3(direction.x, direction.y, 0);
	}
}
