using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDesOnLoad : MonoBehaviour
{
    private static DontDesOnLoad instance;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject); // Kill duplicate
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}