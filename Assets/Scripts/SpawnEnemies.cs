using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    [SerializeField] private int countOfEnemies;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 1.5f, 3f);
    }

    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation);
    }
}
