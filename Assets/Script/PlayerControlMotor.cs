using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlMotor : MonoBehaviour {
	public Vector3 playerSpeed = new Vector3(2.0f,2.0f,2.0f);
	public Vector3 basicVelocity = Vector3.zero;
	public Vector3 velocity = Vector3.zero;
	private float deltaTime = 0;
	// Update is called once per frame
	void FixedUpdate () {
		deltaTime = Time.deltaTime;
		velocity = basicVelocity * deltaTime;
		transform.Translate(Vector3.Scale(velocity,playerSpeed));
	}
}
