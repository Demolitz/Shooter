using UnityEngine;
using TMPro;
public class UIHandler : MonoBehaviour
{
    public int playerHealth, score, enemycount;
    public TextMeshProUGUI healthText, scoreText;
    public UIHandler ui;
    public SceneChanger scenes;
    public ShipHandler player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindObjectOfType<ShipHandler>();
        ui = GameObject.FindObjectOfType<UIHandler>();
        scenes = ui.GetComponent<SceneChanger>();
    }
     
    // Update is called once per frame
    void Update()
    {
        healthText.text = player.health.ToString();
        scoreText.text = score.ToString();
        if (enemycount <= 0)
        {
            scenes.ChangeScene_Clear();
        }
    }
}
