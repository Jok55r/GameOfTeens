using UnityEngine;
using TMPro;

public class WinLogic : MonoBehaviour
{
    [SerializeField] PlayerHealth hp;
    [SerializeField] Timer timer;

    [SerializeField] GameObject panel;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI plusHPText;
    [SerializeField] TextMeshProUGUI plusTimerText;

    public int score = 0;

    public int timeToScoreValue;

    bool showing;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (gameObject.activeSelf && !showing)
        {
            timer.timerActive = false;
            StartCount();
            showing = true;
        }
    }

    private void StartCount()
    {
        score = hp.hp + (int)(timeToScoreValue / timer.currentTime);

        scoreText.text = $"Score: {score}";
        plusHPText.text = $"+ {hp.hp} HP";
        plusTimerText.text = $"+ {(int)(timeToScoreValue / timer.currentTime)} time";
    }
}