using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public Vector2 speed = new Vector2(10,10); // Object Speed
	public Vector2 direction = new Vector2(-1,0); //moving direction

	private Vector2 movement;

	// Use this for initialization
//	void Start () {
//	
//	}
	
	// Update is called once per frame
	void Update () {
		movement = new Vector2 ( speed.y * direction.y, speed.x * direction.x); //movement
	}

	void FixedUpdate(){
		GetComponent<Rigidbody2D>().velocity = movement; //Apply movement to the rigidbody
	}

}
