using UnityEngine;
using TMPro;

public class GameManager : Singleton<GameManager>
{
    public TextMeshProUGUI score, gameOver, highScore;
    public PlayerSpawner pSpawner;
    float scoreEarned = 0;
    float highScoreEarned = 0;
    bool canRetry = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score.text = "Score: 0";
        gameOver.text = "";
        highScore.text = "High Score: 0";
        FruitManager.Instance.spawnFruit();
    }

    // Update is called once per frame
    void Update()
    {
        if (canRetry && Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("supposed to respawn player, reset score, spawn fruit again");
            scoreEarned = 0;
            score.text = "Score: 0";
            gameOver.text = "";
            FruitManager.Instance.spawnFruit();
            pSpawner.spawnEntity();
            gameOver.text = "";
            canRetry = false;
        }
    }

    public void earnScore(float s)
    {
        scoreEarned += s;
        highScoreEarned += s;
        score.text = "Score: " + scoreEarned;
        highScore.text = "High Score: " + highScoreEarned;
        FruitManager.Instance.spawnFruit();
    }

    public void showRetry()
    {
        canRetry = true;
        gameOver.text = "Game Over, R to Restart";
    }
}
