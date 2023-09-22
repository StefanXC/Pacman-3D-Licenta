using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ControlPacman : MonoBehaviour {

    public float VitezaDeMiscare = 14f; 

    private Vector3 up = Vector3.zero,
                        dreapta = new Vector3(0, 90, 0),
                        jos = new Vector3(0, 180, 0),
                        stanga = new Vector3(0, 270, 0),
                        sus = new Vector3(0, 0, 0),
                        directiaCurenta = Vector3.zero;


    private Vector3 pozitiaInitiala = Vector3.zero;


    public void Reset()
    {
        transform.position = pozitiaInitiala;

        directiaCurenta = jos;
    }

	void Start () {
        QualitySettings.vSyncCount = 0;

        pozitiaInitiala = transform.position;

        Reset();


	}

	void Update () {

        var seMisca = true;

        if (Input.GetKey(KeyCode.UpArrow)) directiaCurenta = sus;
        else if (Input.GetKey(KeyCode.DownArrow)) directiaCurenta = jos;
        else if (Input.GetKey(KeyCode.RightArrow)) directiaCurenta = dreapta;
        else if (Input.GetKey(KeyCode.LeftArrow)) directiaCurenta = stanga;
        else seMisca = false;


        transform.localEulerAngles = directiaCurenta;

        if (seMisca) transform.Translate(Vector3.forward * VitezaDeMiscare * Time.deltaTime);
    

    }
   
}
