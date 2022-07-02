using System;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public static bool timerActive;
    public static float currentTime;

    public TextMeshProUGUI currentTimeText;

    void Start()
    {
        currentTime = 0;
        StartTimer();
    }

    void Update()
    {
        if (timerActive)
            currentTime += Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(currentTime);

        currentTimeText.text = time.ToString(@"mm\:ss\.f");
    }

    void StartTimer()
    {
        timerActive = true;
    }

    public void StopTimer()
    {
        timerActive = false;
    }
}