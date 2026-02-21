using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerScore : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void addScore(int ToAddScore)
    {
        score += ToAddScore;
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    
}
