using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    [SerializeField] GameObject panel;

    void Start()
        => Off();

    public void On()
        => panel.SetActive(true);

    public void Off()
        => panel.SetActive(false);
}