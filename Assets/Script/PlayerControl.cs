using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	//移動速度
	public float X_Speed = 2.0f;
	public float Z_Speed = 2.0f;
	public float Y_Speed = 2.0f;

	//カメラタイプ
	//これによって操作する軸が変更される
	public int Type = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float vertical = Input .GetAxis("Vertical");
		float horizontal = Input.GetAxis ("Horizontal");

		//移動
        if (Input.GetKey("up")) {
			if(Type == 0){
				transform.Translate(0, vertical * Y_Speed, 0);
			}else if (Type == 1){
				transform.Translate(vertical * X_Speed, 0, 0);
			}
		}
		if (Input.GetKey("down")) {
			if(Type == 0){
				transform.Translate(0, vertical * Y_Speed, 0);
			}else if (Type == 1){
				transform.Translate(vertical * X_Speed, 0, 0);
			}
		}

		if (Input.GetKey("left")) {
			if(Type == 0){
				transform.Translate(horizontal * X_Speed, 0, 0);
			}else if (Type == 1){
				transform.Translate(0, 0, horizontal * Z_Speed);
			}
		}
		if (Input.GetKey("right")) {
			if(Type == 0){
				transform.Translate(horizontal * X_Speed, 0, 0);
			}else if (Type == 1){
				transform.Translate(0, 0, horizontal * Z_Speed);
			}
		}
	}
}
