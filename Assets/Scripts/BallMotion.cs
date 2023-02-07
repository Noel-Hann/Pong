using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMotion : MonoBehaviour
{
    public float movementSpeed = 5;
    public Rigidbody rb;
    public Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        Vector3 startingForce = Vector3.down * 300f;
        rb.AddForce( startingForce);

        originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z); ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO make this ball bounce correctly based on the angle it hits a wall
    private void OnCollisionEnter(Collision collision)
    {
        
            Vector3 movement = rb.velocity;
            movement = Vector3.Reflect(movement,collision.contacts[0].normal);

            rb.AddForce(movement * 100,ForceMode.Force );
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            this.transform.position = originalPosition;

            Vector3 force;
            if (other.transform.name == "Top Trigger")
            {
                force = Vector3.up * 300;
            } else
            {
                force = Vector3.down * 300;
            }

            rb.velocity = Vector3.zero;
            rb.AddForce(force);
        }
    }
}
