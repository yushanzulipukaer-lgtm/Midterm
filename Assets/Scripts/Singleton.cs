using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Singleton<T> : MonoBehaviour
        where T : MonoBehaviour
{
    public static T Instanse;
    void Awake()
    {
        if(Instanse != null && Instanse!=this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
        Instanse = this as T;
        }
    }
}
