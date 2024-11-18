using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    private Vector3 lastPlatformPosition;
    private GameObject player;

    private void Start()
    {
        lastPlatformPosition = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player = collision.gameObject;
            lastPlatformPosition = transform.position;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            player = null;
        }
    }

    private void Update()
    {
        if (player != null)
        {
            Vector3 platformMovement = transform.position - lastPlatformPosition;

            player.transform.position += platformMovement;
        }

        lastPlatformPosition = transform.position;
    }
}
