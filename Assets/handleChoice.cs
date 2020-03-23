using UnityEngine;
public class handleChoice : MonoBehaviour
{
    public GameObject deadEnd;
    private void OnTriggerEnter()
    {
        deadEnd.SetActive(false);
    }

}
