using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public int healthPoints;    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        
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
