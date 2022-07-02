using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameFunctional : MonoBehaviour
{
    [SerializeField] GameObject panel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Finish")
        {
            panel.SetActive(true);
            print("putin pidor");
        }
    }
}
