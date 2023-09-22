using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPacman : MonoBehaviour {

    public Transform priveste;
    public Transform cameraTransform;

    private Camera cam;

    private float     distanta   = 15.0f;
    private float     curentX    =  0.0f;
    private float     curentY    =  0.0f;
    //private float senzitivitateX =  10.0f;
    //private float senzitivitateY =  1.0f;

    private void Start()
    {
        cameraTransform = transform;
        cam = Camera.main;
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 20, -distanta);
        Quaternion rotation = Quaternion.Euler(curentY, curentX, 0);
        cameraTransform.position = priveste.position + rotation * dir;
    }
}
