using UnityEngine;
using TMPro;

public class WinLogic : MonoBehaviour
{
    [SerializeField] GameObject panel;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI plusHPText;
    [SerializeField] TextMeshProUGUI plusTimerText;

    public int score = 0;

    public int timeToScoreValue;

    private void Awake()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        if (IsEndGame.isGameEnd)
        {
            Timer.timerActive = false;
            panel.SetActive(true);
            StartCount();
        }
    }

    private void StartCount()
    {
        score = PlayerHealth.hp + (int)(timeToScoreValue / Timer.currentTime);

        scoreText.text = $"Score: {score}";
        plusHPText.text = $"+ {PlayerHealth.hp} HP points";
        plusTimerText.text = $"+ {(int)(timeToScoreValue / Timer.currentTime)} time points";
    }
}