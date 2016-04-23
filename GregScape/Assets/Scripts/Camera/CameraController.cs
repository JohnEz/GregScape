using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	const float MOVESPEED = 12; //speed the camera moves
	const float ZOOMSPEED = 0.5f; //speed the camera zooms
	const float MINZOOM = 2f; //minimum zoom value
	const float MAXZOOM = 8f; //maximum zoom value

	public float screenWidth = 0;
	public float screenHeight = 0;

	public bool movingToDestination = false;
	Vector3 targetLocation;

	public float minX = 0;
	public float minY = 0;
	public float maxX = 10;
	public float maxY = 10;

	public GameObject followTarget;

	// Use this for initialization
	void Start () {

	}

	public void Initialise() {

    }
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
	}

	//updates the position of the camera via keyboard input
	void UpdateMovement() {

	}

	void UpdateZoom() {
		float d = Input.GetAxis("Mouse ScrollWheel");


		Camera cam = GetComponent<Camera> ();

		if (d > 0f)
		{
			//zoom in
			cam.orthographicSize -= ZOOMSPEED;

			if (cam.orthographicSize < MINZOOM) {
				cam.orthographicSize = MINZOOM;
			}
		}
		else if (d < 0f)
		{
			//zoom out
			cam.orthographicSize += ZOOMSPEED;
			
			if (cam.orthographicSize > MAXZOOM) {
				cam.orthographicSize = MAXZOOM;
			}
		}
	}


	public void MoveToTarget(Vector3 pos) {
		movingToDestination = true;
		targetLocation = new Vector3 (pos.x, pos.y, transform.position.z);
	}
}
