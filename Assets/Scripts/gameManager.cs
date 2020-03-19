using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    float restartDelay = 2;
    public score scoreText;
    public void endGame()
    {
        if (!gameHasEnded)
        {
            Debug.Log("You lose");
            gameHasEnded = true;
            scoreText.enabled = false;
            Invoke("restart", restartDelay);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
