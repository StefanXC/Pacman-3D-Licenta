using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ContorBani : MonoBehaviour
{
    public int puncte = 0;
    public Text scorText;
    public PacmanManager pacmanManager;

    public bool nivComp = false;
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + puncte);
        scorText.text =" " + puncte +" ";

        if(puncte == 7 && nivComp== false)
        {
            pacmanManager.NivelComplet();
            nivComp = true;
        }
    }
}
