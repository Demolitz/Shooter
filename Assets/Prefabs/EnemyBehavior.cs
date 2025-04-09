using UnityEngine;
using TMPro;
using System;
using System.Collections;
using Random = UnityEngine.Random;

public class EnemyBehavior : MonoBehaviour
{
    public int healthPoints, bulletspeed, movespeed;
    public Rigidbody2D eb;
    public GameObject bullet;
    public Transform bulletspawn;
    public SceneChanger changer;
    public UIHandler ui;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ui = GameObject.FindObjectOfType<UIHandler>();
        eb = gameObject.GetComponent<Rigidbody2D>();
        StartCoroutine(ShootingLoop());
        StartCoroutine(MoveLoop());
        ui.enemycount += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator ShootingLoop()
    {
        while(true)
        {
            float ShootTime = Random.Range(3f, 5f);
            yield return new WaitForSeconds(ShootTime);
            GameObject beam = Instantiate(bullet, bulletspawn.position, bulletspawn.rotation);
            Rigidbody2D bp1 = beam.GetComponent<Rigidbody2D>();
            bp1.linearVelocity = Vector2.down * bulletspeed;
        }
    }

    IEnumerator MoveLoop()
    {
        while (true)
        {
            eb.linearVelocity = Vector2.left * movespeed;
            yield return new WaitForSeconds(2f);
            eb.linearVelocity = Vector2.right * movespeed;
            yield return new WaitForSeconds(4f);
            eb.linearVelocity = Vector2.left * movespeed;
            yield return new WaitForSeconds(4f);
            eb.linearVelocity = Vector2.right * movespeed;
            yield return new WaitForSeconds(2f);
        }
    }

    public void OnDestroy()
    {
        ui.score += 10;
        ui.enemycount -= 1;
    }

}
