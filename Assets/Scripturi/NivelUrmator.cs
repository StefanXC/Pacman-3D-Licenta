
using UnityEngine;
using UnityEngine.SceneManagement;

public class NivelUrmator : MonoBehaviour
{
    public void OpesteTimpul()
    {
        Time.timeScale = 0f;
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
