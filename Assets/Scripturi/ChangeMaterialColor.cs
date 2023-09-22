using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterialColor : MonoBehaviour
{
    [SerializeField] private Material skin;
    [SerializeField] private Material ochi;
    public PacmanStats pacmanStats;

    public void SchimbaInRosu()
    {
        if (skin.color!=Color.red)
        {
            skin.color = Color.red;
            Debug.Log("Culoarea s-a schimbat in ROSU");
            pacmanStats.CumparaSkinCorp();
            pacmanStats.SalveazaProgres();
        }
        else
        {
            Debug.Log("Ai achizitionat deja acest skin");
        }
    }

    public void SchimbaInVerde()
    {
        if (skin.color != Color.green)
        {
            skin.color = Color.green;
            Debug.Log("Culoarea s-a schimbat in VERDE");
            pacmanStats.CumparaSkinCorp();
            pacmanStats.SalveazaProgres();
        }
        else
        {
            Debug.Log("Ai achizitionat deja acest skin");
        }
    }

    public void SchimbaInAlbastru()
    {
        if (skin.color != Color.blue)
        {
            skin.color = Color.blue;
            Debug.Log("Culoarea s-a schimbat in ALBASTRU");
            pacmanStats.CumparaSkinCorp();
            pacmanStats.SalveazaProgres();
        }
        else
        {
            Debug.Log("Ai achizitionat deja acest skin");
        }
    }

    public void SchimbaInMagenta()
    {
        if (skin.color != Color.magenta)
        {
            skin.color = Color.magenta;
            Debug.Log("Culoarea s-a schimbat in MAGENTA");
            pacmanStats.CumparaSkinCorp();
            pacmanStats.SalveazaProgres();
        }
        else
        {
            Debug.Log("Ai achizitionat deja acest skin");
        }
    }

    public void SchimbaInAlb()
    {
        if (skin.color != Color.white)
        {
            skin.color = Color.white;
            Debug.Log("Culoarea s-a schimbat in ALB");
            pacmanStats.CumparaSkinCorp();
            pacmanStats.SalveazaProgres();
        }
        else
        {
            Debug.Log("Ai achizitionat deja acest skin");
        }
    }

    public void SchimbaInGalben()
    {
        if (skin.color != Color.yellow)
        {
            skin.color = Color.yellow;
            Debug.Log("Culoarea s-a schimbat in GALGEN");
            pacmanStats.CumparaSkinCorp();
            pacmanStats.SalveazaProgres();
        }
        else
        {
            Debug.Log("Ai achizitionat deja acest skin");
        }
    }

    public void SchimbaInNegru()
    {
        if (skin.color != Color.black)
        {
            skin.color = Color.black;
            Debug.Log("Culoarea s-a schimbat in NEGRU");
            pacmanStats.CumparaSkinCorp();
            pacmanStats.SalveazaProgres();
        }
        else
        {
            Debug.Log("Ai achizitionat deja acest skin");
        }       
    }

    public void OchiVerzi()
    {
        if (ochi.color != Color.green)
        {
            ochi.color = Color.green;
            Debug.Log("Culoarea ochilor s-a schimbat in VERDE");
            pacmanStats.CumparaSkinOchi();
            pacmanStats.SalveazaProgres();
        }
        else
        {
            Debug.Log("Ai achizitionat deja acest skin");
        }
    }

    public void OchiAlbastri()
    {
        if (ochi.color != Color.blue)
        {
            ochi.color = Color.blue;
            Debug.Log("Culoarea ochilor s-a schimbat in ALBASTRU");
            pacmanStats.CumparaSkinOchi();
            pacmanStats.SalveazaProgres();
        }
        else
        {
            Debug.Log("Ai achizitionat deja acest skin");
        }
    }

    public void OchiRosii()
    {
        if (ochi.color != Color.red)
        {
            ochi.color = Color.red;
            Debug.Log("Culoarea ochilor s-a schimbat in ROSU");
            pacmanStats.CumparaSkinOchi();
            pacmanStats.SalveazaProgres();
        }
        else
        {
            Debug.Log("Ai achizitionat deja acest skin");
        }
    }

    public void OchiAlbi()
    {
        if (ochi.color != Color.white)
        {
            ochi.color = Color.white;
            Debug.Log("Culoarea ochilor s-a schimbat in ALB");
            pacmanStats.CumparaSkinOchi();
            pacmanStats.SalveazaProgres();
        }
        else
        {
            Debug.Log("Ai achizitionat deja acest skin");
        }
    }
}
