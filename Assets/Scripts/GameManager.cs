using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private SpawnFactory factory1;
    [SerializeField] private SpawnFactory factory2;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        Enemy enemy1 = factory1.SpawnEnemy();
        Enemy enemy2 = factory2.SpawnEnemy();
    }
}
