using UnityEngine;
using TMPro;

public class WinLogic : MonoBehaviour
{
    [SerializeField] PlayerHealth hp;
    [SerializeField] Timer timer;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI plusHPText;
    [SerializeField] TextMeshProUGUI plusTimerText;

    public int score = 0;

    public int timeToScoreValue;

    bool showing;

    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        if (gameObject.activeSelf && !showing)
        {
            timer.timerActive = false;
            StartCount();
            showing = true;
        }
    }

    void StartCount()
    {
        score = hp.hp + (int)(timeToScoreValue / timer.currentTime);

        scoreText.text = $"Score: {score}";
        plusHPText.text = $"+ {hp.hp} HP";
        plusTimerText.text = $"+ {(int)(timeToScoreValue / timer.currentTime)} time";
    }
}