using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public Text winText;

    void Start()
    {
        UpdateScoreText();
        winText.text = "";
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();

        if (score >= 20)
        {
            winText.text = "¡Ganaste!";
            // Puedes agregar efectos, detener el juego, etc.
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Puntos: " + score;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

