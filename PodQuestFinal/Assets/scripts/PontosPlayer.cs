using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontosPlayer : MonoBehaviour
{

    int score;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pontos"))
        {
            Debug.Log("Pontos");
            score++;
            Debug.Log(score);
        }
    }
}
