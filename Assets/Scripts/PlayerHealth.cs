using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider slider;

    public static int hp = 100;

    void Update()
    {
        slider.value = hp;
    }
}