using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class YellowEnemyFactory : SpawnFactory
{
    [SerializeField] private Enemy yellowEnemyPrefab;
    [SerializeField] private Transform spawnPoint;

    public override Enemy SpawnEnemy()
    {
        Enemy enemy = Instantiate(yellowEnemyPrefab, spawnPoint.position, Quaternion.identity);
        return enemy;
    }
}
