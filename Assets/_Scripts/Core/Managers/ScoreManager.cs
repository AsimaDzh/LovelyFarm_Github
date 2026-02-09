using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;


    public void AddScore(int points)
    {
        score++;
        scoreText.text = score.ToString();
    }
}
