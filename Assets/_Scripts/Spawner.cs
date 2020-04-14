using UnityEngine;
using System.Collections;

public class Spawner: MonoBehaviour
{
    public GameObject inimigo;

    void Spawn()
    {
        Instantiate(inimigo, new Vector3(Random.Range(-50.0f, 50.0f), 2, Random.Range(-50.0f, 50.0f)), transform.rotation);
    }
}