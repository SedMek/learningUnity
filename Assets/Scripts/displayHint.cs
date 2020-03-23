using UnityEngine;

public class displayHint : MonoBehaviour
{
    public Animator animator;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "player")
        {
            animator.SetTrigger("display hint");
        }
    }
}
