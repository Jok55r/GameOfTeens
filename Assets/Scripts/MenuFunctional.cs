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

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void RelodScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
