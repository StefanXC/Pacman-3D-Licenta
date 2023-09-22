using UnityEngine;

public class ColiziuniFantome : MonoBehaviour
{
    public ControlFantome movementF;


    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Pacman")
        {
            movementF.enabled = false;

        }

    }
}
