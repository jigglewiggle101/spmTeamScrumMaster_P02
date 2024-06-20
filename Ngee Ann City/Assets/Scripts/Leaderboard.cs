using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Dan.Main;

public class Leaderboard : MonoBehaviour
{
    [SerializeField]
    private List<TextMeshProUGUI> names;
    [SerializeField]
    private List<TextMeshProUGUI> scores;
    [SerializeField]
    private TextMeshProUGUI currentScoreLabel;
    private string publicLeaderboardKey = "1c86189e0000d4e66258cf5977319cc62417b3b380355cb4e86726fdaace4329";

    private int currentScore; // Declare currentScore at the class level

    public void GetLeaderboard()
    {
        LeaderboardCreator.GetLeaderboard(publicLeaderboardKey, ((msg) =>
        {
            int loopLength = (msg.Length < names.Count) ? msg.Length : names.Count;
            for (int i = 0; i < loopLength; ++i)
            {
                names[i].text = msg[i].Username;
                scores[i].text = msg[i].Score.ToString();
            }
        }));

    }

    public void SetLeaderboardEntry(string username, int score)
    {
        LeaderboardCreator.UploadNewEntry(publicLeaderboardKey, username, score, ((msg) =>
        {
            //if (System.Array.IndexOf(badWords, name) != -1) return;
            GetLeaderboard();

        }));
    }

    public void UpdateCurrentScore(int score)
    {
        currentScore = score;
        currentScoreLabel.text = score.ToString();
    }

    public void SubmitScore(string username)
    {
        SetLeaderboardEntry(username, currentScore);
    }
}




