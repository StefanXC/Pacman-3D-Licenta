using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PacmanStats : MonoBehaviour
{
    public int nivel = 1;
    public int puncte = 0;
    public int pctTotal = 0;

    public int costSkinCorp = 5;
    public int costSkinOchi = 3;

    public Text scorText;
    public Text scorTotal;
    public PacmanManager pacmanManager;

    public bool nivComp = false;
    private void OnGUI()
    {    
        scorText.text = " " + puncte + " ";
        scorTotal.text = " " + pctTotal + " ";
 
        if (puncte == 3 && nivComp == false)
        {
            pctTotal += puncte;
            pacmanManager.NivelComplet();
            nivComp = true;
            SalveazaProgres();
        }
    }

    public void CumparaSkinCorp()
    {
        if (pctTotal - costSkinCorp >= 0)
        {
            pctTotal -= costSkinCorp;
        }
    }

    public void CumparaSkinOchi()
    {
        if (pctTotal - costSkinOchi >= 0)
        {
            pctTotal -= costSkinOchi;
        }
    }

    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }


    public void SalveazaProgres()
    {
         SalveazaDate.SalveazaProgres(this);
         Debug.Log("Progres salvat");
        Debug.Log("ai " + pctTotal);
    }

    public void Awake()
    {
        PacmanData data = SalveazaDate.IncarcaProgres();

        nivel = data.nivel;
        pctTotal = data.pctTotal;
        Debug.Log("Progres incarcat");
        Debug.Log("ai " + pctTotal);

    }

    #region UI Methods
 
    public void Schimbanivel(int valoare)
    {
        nivel += valoare;
    }

    public void SchimbaBani(int valoare)
    {
        puncte += valoare;
    }

    #endregion
}
