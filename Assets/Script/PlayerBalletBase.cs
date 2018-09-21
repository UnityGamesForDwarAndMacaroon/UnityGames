using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBalletBase : MonoBehaviour {

	public float bulletSpeed = 2;

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 5);
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (bulletSpeed, 0, 0);
	}
}
