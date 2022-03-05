using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public GameObject player;
    public float jumpForce = 5f;

    Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        //direction = transform.TransformDirection(Vector3.up * jumpForce);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject;

            
            player.GetComponent<CharacterController>().Move(Vector3.up * jumpForce);
        }
    }
}
