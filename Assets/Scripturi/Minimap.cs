using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Transform pacman;

    void LateUpdate()
    {
        Vector3 newPosition = pacman.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
    }
}
