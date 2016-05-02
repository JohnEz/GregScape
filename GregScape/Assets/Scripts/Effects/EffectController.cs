using UnityEngine;
using System.Collections;

public class EffectController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, this.GetComponentInChildren<Animator> ().GetCurrentAnimatorStateInfo (0).length);
	}
	

}
