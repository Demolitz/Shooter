using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene_Level_1()
    {
        SceneManager.LoadScene("SpaceShooter");
    }

    public void ChangeScene_GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void ChangeScene_Clear()
    {
        SceneManager.LoadScene("Clear");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
