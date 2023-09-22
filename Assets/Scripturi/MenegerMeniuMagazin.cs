using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenegerMeniuMagazin : MonoBehaviour
{
        public GameObject Panel;

        public void AfiseazaMagazin()
        {
            if (Panel != null)
            {
                bool isActive = Panel.activeSelf;
                Panel.SetActive(!isActive);
            }
        }
}
