using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPathController : MonoBehaviour {
    public Transform pathMoveObject;
    public Vector3 addRotation;
    private void Update()
    {
        transform.position = pathMoveObject.position;
        transform.eulerAngles = new Vector3(0,pathMoveObject.eulerAngles.y,0);
        transform.Rotate(addRotation);
    }
}
