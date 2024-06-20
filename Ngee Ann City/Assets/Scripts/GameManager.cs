using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public Leaderboard leaderboard; // Ensure this is assigned in the Inspector

    private int currentScore;

    private void Start()
    {
        // Initialize the score
        currentScore = 0;
        leaderboard.UpdateCurrentScore(currentScore); // Update the leaderboard display
    }

    public void AddPoints(int points)
    {
        currentScore += points;
        leaderboard.UpdateCurrentScore(currentScore); // Update the leaderboard display
    }

    public void OnGameEnd(string username)
    {
        leaderboard.SubmitScore(username); // Submit the score to the leaderboard
    }
}

