using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class GameManagerScript : MonoBehaviour
{
    public int score; // Player's score

    public TextMeshProUGUI scoreText; //score UI displayed on Screen

    public static GameManagerScript _gameManager; // Reference to the GameManagerScript script

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        _gameManager = this;
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScore(int scoreToAdd) // method to update score on game scene
    {
        score += scoreToAdd;
        scoreText.text = "Money: £ " + score;
    }
}
