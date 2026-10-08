using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnFactory : MonoBehaviour
{
    public abstract Enemy SpawnEnemy();
}
