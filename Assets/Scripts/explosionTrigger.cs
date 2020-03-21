
using UnityEngine;

public class explosionTrigger : MonoBehaviour
{
    public Rigidbody sphereRb;
    void OnTriggerEnter()
    {
        sphereRb.useGravity = true;
    }
}
