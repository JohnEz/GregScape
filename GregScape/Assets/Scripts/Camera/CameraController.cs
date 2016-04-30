using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	const float MOVESPEED = 1; //speed the camera moves
	const float ZOOMSPEED = 1; //speed the camera zooms
	const float MINZOOM = 1; //minimum zoom value
	const float MAXZOOM = 4; //maximum zoom value

	public float screenWidth = 0;
	public float screenHeight = 0;

	public bool movingToDestination = false;
	Vector3 targetLocation;
	float zoomMod = 1f;

	public Transform target;
	Camera myCam;

	// Use this for initialization
	void Start () {
		myCam = GetComponent<Camera> ();
	}

	public void Initialise() {

    }
	
	// Update is called once per frame
	void Update () {
		UpdateMovement ();
		UpdateZoom ();
	}

	//updates the position of the camera via keyboard input
	void UpdateMovement() {

		if (target) {
			transform.position = Vector3.Lerp (transform.position, target.position, MOVESPEED) + new Vector3(0, 0, -10);
		}

	}

	void UpdateZoom() {
		float d = Input.GetAxis("Mouse ScrollWheel");

		if (d < 0)
		{
			//zoom in
			zoomMod -= ZOOMSPEED;

			if (zoomMod < MINZOOM) {
				zoomMod = MINZOOM;
			}
		}
		else if (d > 0)
		{
			//zoom out
			zoomMod += ZOOMSPEED;
			
			if (zoomMod > MAXZOOM) {
				zoomMod = MAXZOOM;
			}
		}

		myCam.orthographicSize = (Screen.height / 100) / zoomMod;
	}

}
