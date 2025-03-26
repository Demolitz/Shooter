using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene_Level_1()
    {
        SceneManager.LoadScene("SpaceShooter");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
