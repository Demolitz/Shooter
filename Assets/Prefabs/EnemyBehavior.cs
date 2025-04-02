using UnityEngine;
using TMPro;
using System;

public class EnemyBehavior : MonoBehaviour
{
    public int healthPoints;
    public UIHandler ui;
    public ShipHandler ship;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ship = GetComponent<ShipHandler>();
        ui = GetComponent<UIHandler>();
        ui.enemyCount += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        ui.enemyCount -= 1;
    }

}
