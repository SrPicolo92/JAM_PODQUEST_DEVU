using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontosPonto : MonoBehaviour
{
    SpriteRenderer rend;
    BoxCollider2D co;

    void Start()
    {
        rend = this.gameObject.GetComponent<SpriteRenderer>();
        co = this.gameObject.GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            rend.enabled = false;
            co.enabled = false;
        }
    }
}
