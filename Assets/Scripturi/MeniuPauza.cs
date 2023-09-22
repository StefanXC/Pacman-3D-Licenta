using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeniuPauza : MonoBehaviour
{
    public static bool Pauza = false;
    public GameObject meniuPauza;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (Pauza)
                Resume();
            else
                Pause();
        }
    }

    public void Resume()
    {
        meniuPauza.SetActive(false);
        Time.timeScale = 1f;
        Pauza = false;
    }

    void Pause()
    {
        meniuPauza.SetActive(true);
        Time.timeScale = 0f;
        Pauza = true;
    }

    public void Meniu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Meniu");
        Debug.Log("Intra in meniu");

    }

    public void IesiJoc()
    {
        Debug.Log("Iesi din joc");
        Application.Quit();

    }

}
