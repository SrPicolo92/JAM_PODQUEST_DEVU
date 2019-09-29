using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timmer : MonoBehaviour
{
    [SerializeField] private Text uiText;
    [SerializeField] private float MaxTimer;

    public GameObject PlayAgain;
    public Movement movement;
    private float timer;
    private bool canCount = true;
    private bool doOnce = false;

    private bool GameOver = false;

    void Start()
    {
        timer = MaxTimer;
    }

    void Update()
    {
        if (timer >= 0.0f && canCount)
        {
            timer -= Time.fixedDeltaTime;
            uiText.text = timer.ToString("F");
        }

        else if (timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.0f;
        }

        if (doOnce)
        {
            GameOver = true;
            Debug.Log("GAME OVER!");
        }

        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            Time.timeScale = 0.001f;
            Debug.Log("Tempo Diminuido: " + Time.timeScale);
        }

        else
        {
            Time.timeScale = 1.0f;
            Debug.Log("Tempo Normal: " + Time.timeScale);
        }

        if (GameOver)
        {
            PlayAgain.SetActive(true);
            movement.isEnabled = false;
        }

        else
        {
            PlayAgain.SetActive(false);

        }

        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
}
