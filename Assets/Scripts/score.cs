using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        var normalizedScore = (player.position.z / 10);
        scoreText.text = normalizedScore.ToString("0");

    }
}
