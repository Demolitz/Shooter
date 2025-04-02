using UnityEngine;
using TMPro;
public class UIHandler : MonoBehaviour
{
    public int playerHealth, enemyCount;
    public TextMeshProUGUI healthText;
    public SceneChanger scenes;
    public ShipHandler player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scenes = gameObject.GetComponent<SceneChanger>();
        player = gameObject.GetComponent<ShipHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = player.health.ToString();
        if (player.health == 0)
        {
            scenes.ChangeScene_Fail();
        }
    }
}
