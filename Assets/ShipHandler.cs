using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 5f, bulletspeed = 7f;
    private Rigidbody2D rb;
    public GameObject beam;
    public Transform bulletspawn, bulletspawn2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical"); 

        rb.linearVelocity = new Vector2 (horizontalInput * moveSpeed, verticalInput * moveSpeed);

        if(Input.GetKeyDown(KeyCode.Space))
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
