using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PacmanData
{
    public int nivel;
    public int pctTotal;

    public PacmanData(PacmanStats pacman)
    {
        nivel = pacman.nivel;
        pctTotal = pacman.pctTotal;
    }
}
