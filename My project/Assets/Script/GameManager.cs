using UnityEngine;
using TMPro;

public class GameManager : Singleton<GameManager>
{
    public TextMeshProUGUI score, gameOver;
    float scoreEarned = 0;
    bool canRetry = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score.text = "Score: 0";
        gameOver.text = "";
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
            canRetry = false;
        }
    }

    public void earnScore(float s)
    {
        scoreEarned += s;
        score.text = "Score: " + scoreEarned;
    }

    public void showRetry()
    {
        canRetry = true;
    }
}
