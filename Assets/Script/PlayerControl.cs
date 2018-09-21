using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	// インスペクター上から追加
	public PlayerControlMotor pcMotor;

	//カメラタイプ
	//これによって操作する軸が変更される
	public enum eType
	{
		VERTICALSCROLL,
		HORIZONTALSCROLL
	}
	public eType type = eType.VERTICALSCROLL;

	// Update is called once per frame
	void Update () {
		float vertical = Input .GetAxis("Vertical");
		float horizontal = Input.GetAxis ("Horizontal");
		pcMotor.basicVelocity = new Vector3();

		switch(type){
			case eType.VERTICALSCROLL:
				pcMotor.basicVelocity += new Vector3(horizontal,vertical,0);
				break;
			case eType.HORIZONTALSCROLL:
				pcMotor.basicVelocity += new Vector3(vertical,0,horizontal);
				break;
		}

		/*
		if (Input.GetKey("up")) {
			switch(type){
				case eType.VERTICALSCROLL:
					pcMotor.basicVelocity += new Vector3(0,vertical,0);
					break;
				case eType.HORIZONTALSCROLL:
					pcMotor.basicVelocity += new Vector3(vertical,0,0);
					break;
			}
		}
		if (Input.GetKey("down")) {
			switch(type){
				case eType.VERTICALSCROLL:
					pcMotor.basicVelocity += new Vector3(0,vertical,0);
					break;
				case eType.HORIZONTALSCROLL:
					pcMotor.basicVelocity += new Vector3(vertical,0,0);
					break;
			}
		}

		if (Input.GetKey("left")) {
			switch(type){
				case eType.VERTICALSCROLL:
					pcMotor.basicVelocity += new Vector3(horizontal,0,0);
					break;
				case eType.HORIZONTALSCROLL:
					pcMotor.basicVelocity += new Vector3(0,0,horizontal);
					break;
			}
		}
		if (Input.GetKey("right")) {
			switch(type){
				case eType.VERTICALSCROLL:
					pcMotor.basicVelocity += new Vector3(horizontal,0,0);
					break;
				case eType.HORIZONTALSCROLL:
					pcMotor.basicVelocity += new Vector3(0,0,horizontal);
					break;
			}
		}
		*/
	}
}
