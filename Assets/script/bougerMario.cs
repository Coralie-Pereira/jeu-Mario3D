using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BougerMario : MonoBehaviour{

    public float rotationSpeed = 5.0f; // Vitesse de rotation du personnage
    public float moveSpeed = 5.0f; // Vitesse de déplacement du personnage

    void Update()
    {
        // Rotation horizontale du personnage
        float horizontalRotation = Input.GetAxis("Horizontal");
        transform.Rotate(horizontalRotation * rotationSpeed * Time.deltaTime * Vector3.up);

        // Déplacement vertical du personnage
        float verticalMovement = Input.GetAxis("Vertical");
        transform.Translate(moveSpeed * Time.deltaTime * verticalMovement * Vector3.forward);
    }
}



