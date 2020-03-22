using UnityEngine;

public class playerDash : MonoBehaviour
{

    private Rigidbody rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private float cooldownTimer;
    public float dashCooldown;
    private int direction;
    private Vector3 normalVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (direction == 0)
        {
            if (cooldownTimer <= 0)
            {
                if ((Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftShift)) && (Input.GetKeyDown(KeyCode.Q) || Input.GetKey(KeyCode.Q)))
                {
                    normalVelocity = rb.velocity;
                    direction = -1; //-1 for left
                    cooldownTimer = dashCooldown;
                }
                else if ((Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftShift)) && (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.D)))
                {
                    normalVelocity = rb.velocity;
                    direction = 1; // 1 for right
                    cooldownTimer = dashCooldown;
                }
            }
            else { cooldownTimer -= Time.fixedDeltaTime; }
        }
        else
        {
            if (dashTime <= 0)
            {
                rb.velocity = normalVelocity;
                direction = 0;
                dashTime = startDashTime;
            }
            else
            {
                dashTime -= Time.fixedDeltaTime;
                if (direction == -1)
                {
                    rb.velocity += Vector3.left * dashSpeed;
                }
                else if (direction == 1)
                {
                    rb.velocity += Vector3.right * dashSpeed;
                }
            }
        }
    }
}
