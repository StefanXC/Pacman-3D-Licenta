using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PacmanManager : MonoBehaviour
{
    bool joculSaSf = false;
    public float restartDelay = 1f;
    public GameObject nivelcompletUI;

    public int nivelDeDeblocat = 2;
    public string nivelUrmator = "Nivel02";



    public void NivelComplet()
    {
        nivelcompletUI.SetActive(true);

        PlayerPrefs.SetInt("nivelAtins", nivelDeDeblocat);
        Debug.Log("Nivel Complet!");

    }
    

    #region Singleton

    public static PacmanManager instance;

    void Awake()
    {
        Time.timeScale = 1f;
        instance = this;
    }

    #endregion

    public GameObject pacman;


    public void EndGame()
    {

        if (joculSaSf == false)
        {
            joculSaSf = true;
            Debug.Log("Game Over");
            //Restart game
            Invoke("Restart", restartDelay);
        }
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

       
    }

}
