using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider slider;

    public int hp = 100;

    void Update()
    {
        slider.value = hp;
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        hp--;
    }*/
}