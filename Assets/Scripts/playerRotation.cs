using UnityEngine;

public class playerRotation : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "obstacle")
        {
            Debug.Log("ooh scary");
            animator.SetTrigger("player rotate");
        }
    }
}
