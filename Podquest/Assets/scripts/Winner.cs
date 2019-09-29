using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Winner : MonoBehaviour
{
    SpriteRenderer rend;
    BoxCollider2D co;
    public GameObject winner;
    public Movement movement;


    void Start()
    {
        rend = this.gameObject.GetComponent<SpriteRenderer>();
        co = this.gameObject.GetComponent<BoxCollider2D>();
        winner.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Chegou!");
            winner.SetActive(true);
            movement.isEnabled = false;

        }
    }
}
