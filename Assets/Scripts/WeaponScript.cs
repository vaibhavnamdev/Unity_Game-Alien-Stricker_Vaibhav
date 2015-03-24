using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {

	public Transform shotPrefab;
	public float shootingRate = 0.25f; //cooldown in seconds between two shots
	private float shootCooldown;
	// Use this for initialization
	void Start () {
		shootCooldown = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (shootCooldown > 0) {
			shootCooldown -= Time.deltaTime;
		}
	}

	public void Attack(bool isEnemy){
		if (CanAttack) {
			shootCooldown = shootingRate;

			var shotTransform = Instantiate(shotPrefab) as Transform; // create a new shot

			shotTransform.position = transform.position; // Assign position

			ShotScript shot = shotTransform.gameObject.GetComponent<ShotScript>(); //the isEnemy property
			if(shot!=null){
				shot.isEnemyShot = isEnemy;
			}

			// make the weapon shot always towards it
			MoveScript move = shotTransform.gameObject.GetComponent<MoveScript>();
			if(move!=null){
				move.direction =this.transform.right; //towards in 2D space is the right of the sprite
			}
		}
	}

	public bool CanAttack{
		get{
			return shootCooldown <= 0f;
		}
	}
}
