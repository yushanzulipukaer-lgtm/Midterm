using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RedEnemyFactory : SpawnFactory
{
    [SerializeField] private Enemy redEnemyPrefab;
    [SerializeField] private Transform spawnPoint;

    public override Enemy SpawnEnemy()
    {
        Enemy enemy = Instantiate(redEnemyPrefab,spawnPoint.position,Quaternion.identity);
        return enemy;
    }
}
