using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumaraBanutzi : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Pacman")
        {
            other.GetComponent<PacmanStats>().puncte++;
            Destroy(gameObject);

        }
    }
}
