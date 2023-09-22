using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MotorPacman))]

public class ControlPacmanV2 : MonoBehaviour {

    [SerializeField]
    private float viteza = 10f;
    [SerializeField]
    private float lookSensitivity = 3f;

    private MotorPacman motor;

    void Start()
    {
        motor = GetComponent<MotorPacman>();

    }

    void Update()
    {
        //Calculam miscarea cu ajutorul unui vector 3D
        float xMiscare = Input.GetAxisRaw("Horizontal");
        float zMiscare = Input.GetAxisRaw("Vertical");

        Vector3 miscareOrizontala = transform.right * xMiscare;
        Vector3 miscareVerticala = transform.forward * zMiscare;

        //Vectorul de miscare final
        Vector3 velocity = (miscareVerticala + miscareOrizontala).normalized * viteza;
        
        //Aplicam miscarea
        motor.Muta(velocity);

        //Calculam rotatie cu ajutorul unui vector 3D
        float yRotire = Input.GetAxisRaw("Mouse X");

        Vector3 _rotire = new Vector3(0f, yRotire, 0f) * lookSensitivity;

        //Aplicam rotatia
        motor.Rotatie(_rotire);


    }
}
