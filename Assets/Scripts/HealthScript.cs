using UnityEngine;
using System.Collections;

//handle hitpoints and damages
public class HealthScript : MonoBehaviour {

	public int hp = 1; //total hitpoints
	public bool isEnemy = true; // Enemy or player?
	// Use this for initialization
//	void Start () {
//	
//	}

	// Inflicts damage and check if the object should be destroyed
	public void Damage(int damageCount){
		hp -= damageCount;
		if (hp <= 0) {
			Destroy(gameObject);

		}
	}

	void OnTriggerEnter2D(Collider2D otherCollider){
		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript> (); //is this shot??
		if (shot != null) {
			if(shot.isEnemyShot != isEnemy){	//Avoid Friendly fire
				Damage(shot.damage);
				Destroy(shot.gameObject); //destroy the shot
			}
		}
	}
	// Update is called once per frame
//	void Update () {
//	
//	}
}
