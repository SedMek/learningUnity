using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;

    public Rigidbody rb;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag != "ground" && collisionInfo.collider.tag != "body")
        {
            Debug.Log(collisionInfo.collider.tag);
            movement.enabled = false;
            rb.useGravity = false;
            FindObjectOfType<gameManager>().endGame();

        }
    }
}
