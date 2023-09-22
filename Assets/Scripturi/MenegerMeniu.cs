using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenegerMeniu : MonoBehaviour
{
    public GameObject Panel;

    int nivelTerminat;

    public Button[] butoaneNivele;

    void Start()
    {
        int nivelAtins = PlayerPrefs.GetInt("nivelAtins", 0);

        for (int i = 0 ; i < butoaneNivele.Length ; i++)
        {
            if(i > nivelAtins)
            butoaneNivele[i].interactable = false;

        }



       /* nivelTerminat = PlayerPrefs.GetInt("NivelTerminat");
        butonNiv01.interactable = false;
        butonNiv02.interactable = false;
        butonNiv03.interactable = false;
        butonNiv04.interactable = false;
        butonNiv05.interactable = false;
        butonNiv06.interactable = false;

        switch(nivelTerminat){
            case 1:
             butonNiv01.interactable = true;
            break;
            case 2:
             butonNiv01.interactable = true;
             butonNiv02.interactable = true;
             break;
        }*/
    }

    public void AfiseazaNivele()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }
    
   /* public void JoacaNivel(int nivel)
    {
        SceneManager.LoadScene(nivel);
    } */

    public void JoacaTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void JoacaNivel1()
    {
        SceneManager.LoadScene("Nivel01");
    }

    public void JoacaNivel2()
    {
        SceneManager.LoadScene("Nivel02");
    }

    public void JoacaNivel3()
    {
        SceneManager.LoadScene("Nivel03");
    }

    public void JoacaNivel4()
    {
        SceneManager.LoadScene("Nivel04");
    }
    
    public void JoacaNivel5()
    {
        SceneManager.LoadScene("Nivel05");
    }

    public void JoacaNivel6()
    {
        SceneManager.LoadScene("Nivel06");
    }

}


