using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Rigidbody2D rBody;
	Animator anim;
	BaseCharacter character;
	const float MOVESPEED = 15;

	//TODO MAYBE SOME CONTROLLER CLASS?
	bool attack1 = false;
	bool attack2 = false;
	float horizontalInput;
	float verticalInput;
	Vector2 direction;


	// Use this for initialization
	void Start () {

		rBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		character = GetComponent<BaseCharacter> ();

	}
	
	// Update is called once per frame
	void Update () {
		UpdateInputs ();
		Movement ();
		FaceMouse ();
		Attacks ();
	}

	void UpdateInputs () {
		attack1 = Input.GetMouseButton (0);
		attack2 = Input.GetMouseButton (1);
		horizontalInput = Input.GetAxisRaw ("Horizontal");
		verticalInput = Input.GetAxisRaw ("Vertical");
		direction = new Vector2 (Input.mousePosition.x-(Screen.width/2), Input.mousePosition.y-(Screen.height/2));
		direction.Normalize ();

	}

	void Attacks() {
		if (attack1) {
			character.Attack1 (transform.position, direction);
		}

		if (attack2) {
			character.Attack2 (transform.position, direction);
		}
	}

	void FaceMouse() {
		anim.SetFloat ("inputX", direction.x);
		anim.SetFloat ("inputY", direction.y);
	}

	void Movement () {
		
		Vector2 movementInput = new Vector2(horizontalInput, verticalInput);

		movementInput.Normalize ();


		//if there are inputs
		if (movementInput != Vector2.zero) {
			anim.SetBool ("isWalking", true);
		} else {
			anim.SetBool ("isWalking", false);
		}

		rBody.MovePosition (rBody.position + (movementInput * Time.deltaTime * character.Movespeed));
	}
}
