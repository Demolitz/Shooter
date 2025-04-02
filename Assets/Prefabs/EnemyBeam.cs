using Unity.VisualScripting;
using UnityEngine;

public class EnemyBeam : MonoBehaviour
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
        if (collision.gameObject.CompareTag("Player"))
        {
            ShipHandler player = collision.GetComponent<ShipHandler>();
            player.health -= dmg;
            Destroy(gameObject);
        }
    }
}
