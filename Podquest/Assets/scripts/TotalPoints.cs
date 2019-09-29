using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalPoints : MonoBehaviour
{
    [SerializeField] private Text pontuacao;
    [SerializeField] private Text pontuacao2;

    public int points = 0;

    void Update()
    {
        pontuacao.text = points.ToString();
        pontuacao2.text = points.ToString();
    }
}
