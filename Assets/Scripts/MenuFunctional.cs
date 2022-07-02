using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuFunctional : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup mixer;

    [SerializeField] private Slider masterSld;
    [SerializeField] private Slider musicSld;
    [SerializeField] private Slider SFXSld;

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

    public void ChangeMasterVolume()
    {
        mixer.audioMixer.SetFloat("MasterVolume", masterSld.value);
    }

    public void ChangeMusicVolume()
    {
        mixer.audioMixer.SetFloat("MusicVolume", musicSld.value);
    }

    public void ChangeSFXVolume()
    {
        mixer.audioMixer.SetFloat("SFXVolume", SFXSld.value);
    }

    public void QuitGame()
    {
        clickEffect.Play();
        Application.Quit();
    }
}
