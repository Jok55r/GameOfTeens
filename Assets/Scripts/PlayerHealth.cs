using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public static AudioSource hitEffect;

    public Slider slider;

    public static int hp = 100;

    private void Update()
    {
        slider.value = hp;
    }

    public static void TakeDamage()
    {
        hitEffect.Play();
        hp--;
    }
}