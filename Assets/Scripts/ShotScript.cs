using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {

	public int damage = 1; //Damage inflicted
	public bool isEnemyShot = false; //projectile damage player or enemies?

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 20); //Limited time to live to avoid any leak..20 sec
	}
	
	// Update is called once per frame
//	void Update () {
//
//	}
}
