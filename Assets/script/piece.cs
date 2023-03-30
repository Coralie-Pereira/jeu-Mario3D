using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piece : MonoBehaviour
{

    private void collesionpiece(Collision collision) {
        if (collision.gameObject.CompareTag("Items")) {
            Destroy(collision.gameObject);
                }
    }
    // Start is called before the first frame update
    
}
