using Unity.VisualScripting;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public int dmg;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            EnemyBehavior enemy = collision.GetComponent<EnemyBehavior>();
            enemy.healthPoints -= dmg;
            Destroy(gameObject);
        }
    }
}
