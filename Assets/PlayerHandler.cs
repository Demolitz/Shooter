using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public float moveSpeed;
    public Animator playerAnimation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerAnimation = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            playerAnimation.SetBool("isMovingRight", true);
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            playerAnimation.SetBool("isMovingRight", false);
        }
        if (Input.GetKey(KeyCode.A))
        {   
            playerAnimation.SetBool("isMovingLeft", true);
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        else
        {
            playerAnimation.SetBool("isMovingLeft", false);
        }
    }
}
