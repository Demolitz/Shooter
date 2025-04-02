using UnityEngine;
using TMPro;
using System;

public class EnemyBehavior : MonoBehaviour
{
    public int healthPoints;
    public ShipHandler player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<ShipHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
