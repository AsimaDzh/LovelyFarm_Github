using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    private ScoreManager scoreManager;

    public TextMeshProUGUI scoreTextUI;
    public GameObject gameOverPanel;

    void Start()
    {
        Time.timeScale = 1f;
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    void Update()
    {
        scoreTextUI.text = "Points earned: " + scoreManager.score.ToString();
    }

    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Prototype 2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
