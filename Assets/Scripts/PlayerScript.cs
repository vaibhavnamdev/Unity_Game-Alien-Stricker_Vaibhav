using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	private int counter;

	public Vector2 speed = new Vector2(10, 10); // Speed of the ship
	private Vector2 movement; //Store the movement
	// Use this for initialization
	//	void Start () {
	//	
	//	}

	// Update is called once per frame
	void Update () {
		//Retrieve axis information
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		
		//Movement per direction
		movement = new Vector2 (speed.x * inputX, speed.y * inputY);
		
		bool shoot = Input.GetButtonDown("Fire1");
		shoot |= Input.GetButtonDown("Fire2");
		
		if (shoot) {
			WeaponScript weapon = GetComponent<WeaponScript>();
			if(weapon != null){
				weapon.Attack(false);
			}
		}
		
	}

	void FixedUpdate(){
		GetComponent<Rigidbody2D>().velocity = movement; // move the game object.
	}
}