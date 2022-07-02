using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] GameObject panel;

    [SerializeField] private AudioSource hitEffect;

    public Slider slider;

    public static int hp = 100;

    private void Awake()
    {
        panel.SetActive(false);
        hp = 100;
    }

    private void Update()
    {
        slider.value = hp;
        if (hp <= 0)
        {
            panel.SetActive(true);
            CarLogic.canRide = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Water")
        {
            hitEffect.Play();
            hp--;
        }
    }
}