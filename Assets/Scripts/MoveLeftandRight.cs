using UnityEngine;
using System.Collections;

public class MoveLeftandRight : MonoBehaviour {

	public float speed = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Moves object left/right, up/down
		transform.position += Vector3.right*Input.GetAxis("Horizontal")*speed*Time.deltaTime;
		transform.position += Vector3.up * Input.GetAxis ("Vertical")*speed*Time.deltaTime;
	}
}
