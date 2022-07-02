using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunctional : MonoBehaviour
{
    [SerializeField] private GameObject tutorialPanel;
    [SerializeField] private AudioSource clickEffect;
        
    private void Start()
    {
        tutorialPanel.SetActive(false);
    }

    public void StartGame()
    {
        clickEffect.Play();
        SceneManager.LoadScene("Game");
    }

    public void OpenPanel(GameObject panel)
    {
        clickEffect.Play();
        panel.SetActive(true);
    }

    public void ClosePanel(GameObject panel)
    {
        clickEffect.Play();
        panel.SetActive(false);
    }

    public void QuitGame()
    {
        clickEffect.Play();
        Application.Quit();
    }
}
