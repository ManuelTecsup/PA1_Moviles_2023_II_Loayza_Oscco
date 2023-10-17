using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lista_SO : MonoBehaviour
{
    public List<ScriptableObject> scriptableObjects;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
