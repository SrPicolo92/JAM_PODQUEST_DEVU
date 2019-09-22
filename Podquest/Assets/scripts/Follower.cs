using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Movement player;

    public Rigidbody2D cameraBody;

    void Start()
    {
        cameraBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        cameraBody.MovePosition(player.rb.position + player.movement * player.moveSpeed * Time.fixedDeltaTime);
    }
}
