using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float forwardStep = 50f;
    public float sideStep = 20f;
    public Rigidbody rb;

    public Animator animator;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardStep * Time.fixedDeltaTime, ForceMode.VelocityChange);
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -forwardStep * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, sideStep * Time.fixedDeltaTime, 0, ForceMode.VelocityChange);
            animator.SetTrigger("player rotate");
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddForce(-sideStep * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sideStep * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < 272)
        {
            FindObjectOfType<gameManager>().endGame();
        }
    }
}
