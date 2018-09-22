using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour {

	public GameObject ballet;
	float intervalTime;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		intervalTime += Time.deltaTime;
		if (Input.GetKey("space")) {
			if (intervalTime >= 0.2f) {
				Instantiate(ballet, transform.position, Quaternion.identity);
				intervalTime = 0.0f;
			}
		}
	}
}
