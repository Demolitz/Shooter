using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using System.Runtime.CompilerServices;

public class ShipHandler : MonoBehaviour
{
    public int health;
    public float moveSpeed = 5f, bulletspeed = 7f;
    private Rigidbody2D rb;
    public GameObject beam;
    public Transform bulletspawn, bulletspawn2;
    public SceneChanger changer;
    public UIHandler ui;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ui = GameObject.FindObjectOfType<UIHandler>();
        changer = ui.GetComponent<SceneChanger>();
        rb = GetComponent<Rigidbody2D>();
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            changer.ChangeScene_GameOver();
        }

        float horizontalInput = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, 0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(beam, bulletspawn.position, bulletspawn.rotation);
            GameObject bullet2 = Instantiate(beam, bulletspawn2.position, bulletspawn2.rotation);
            Rigidbody2D bp1 = bullet.GetComponent<Rigidbody2D>();
            Rigidbody2D bp2 = bullet2.GetComponent<Rigidbody2D>();
            bp1.linearVelocity = Vector2.up * bulletspeed;
            bp2.linearVelocity = Vector2.up * bulletspeed;
        }
    }
}
