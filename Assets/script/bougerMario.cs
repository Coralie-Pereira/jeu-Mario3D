using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bougerMario : MonoBehaviour{

    public float rotationSpeed = 25.0f; // Vitesse de rotation du personnage
    public float verticalSpeed = 24.5f; // Vitesse de d�placement verticale
    public float jumpSpeed = 10.0f; // Vitesse de d�placement en saut
    public float jumpHeight = 10.0f; // Hauteur de saut du personnage
    public bool isGrounded = true; // Bool�en indiquant si le personnage est au sol

    void Update()
    {
        // D�placement horizontal du personnage
        float horizontalMovement = Input.GetAxis("Horizontal");
        transform.Rotate( horizontalMovement * rotationSpeed * Time.deltaTime * Vector3.up);

        // D�placement vertical du personnage
        float verticalMovement = Input.GetAxis("Vertical");
        transform.Translate(Time.deltaTime * verticalMovement * verticalSpeed * Vector3.forward * -1);

        // Saut du personnage
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            float jumpVelocity = Mathf.Sqrt(jumpHeight * -2.0f * Physics.gravity.y);
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // V�rifie si le personnage est au sol
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }



}



