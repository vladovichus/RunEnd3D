using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score;

    
    public static GameManager inst;

    [SerializeField] Text scoreText;

    [SerializeField] PlayerMovement playerMovement;

    [SerializeField] Text healthText;

    public void IncrementScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
        playerMovement.speed += playerMovement.speedIncreasePerPoint;
    }

    void update()
    {
        //healthText.text = "Health: " + playerMovement.health;
    }

    private void Awake()
    {
        inst = this;
    }
}

