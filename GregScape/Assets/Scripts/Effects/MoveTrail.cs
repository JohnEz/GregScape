using UnityEngine;
using System.Collections;

public class MoveTrail : MonoBehaviour {

	public float movespeed = 30;
	public float lifeTime = 1;

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * Time.deltaTime * movespeed);
		Destroy (gameObject, lifeTime); 
	}
}
