using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene_Level_1()
    {
        SceneManager.LoadScene("SpaceShooter");
    }

    public void ChangeScene_Clear()
    {
        SceneManager.LoadScene("Clear");
    }

    public void ChangeScene_Fail()
    {
        SceneManager.LoadScene("Fail");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
