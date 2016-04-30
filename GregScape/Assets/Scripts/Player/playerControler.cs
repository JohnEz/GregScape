using UnityEngine;
using System.Collections;

public class playerControler : MonoBehaviour {

	Rigidbody2D rBody;
	Animator anim;
	BaseCharacter character;
	const float MOVESPEED = 15;


	// Use this for initialization
	void Start () {

		rBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		character = GetComponent<BaseCharacter> ();

	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
	}

	void Movement () {
		
		Vector2 movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		movementInput.Normalize ();

		//if there are inputs
		if (movementInput != Vector2.zero) {
			anim.SetBool ("isWalking", true);
			anim.SetFloat ("inputX", movementInput.x);
			anim.SetFloat ("inputY", movementInput.y);
		} else {
			anim.SetBool ("isWalking", false);
		}

		rBody.MovePosition (rBody.position + (movementInput * Time.deltaTime * character.Movespeed));
	}
}
