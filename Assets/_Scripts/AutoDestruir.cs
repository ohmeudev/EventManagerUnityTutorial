using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestruir: MonoBehaviour
{
    void Destroi()
    {
        Destroy(gameObject, Random.Range(1,10));
    }
}
