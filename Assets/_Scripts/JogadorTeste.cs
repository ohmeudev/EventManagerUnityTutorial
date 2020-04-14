using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorTeste : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            Debug.Log("Spaw minion");
        }

        if (Input.GetKeyDown("d"))
        {
            Debug.Log("Minions_kill");
        }
    }
}
