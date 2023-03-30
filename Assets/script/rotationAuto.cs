using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class rotationAuto : MonoBehaviour
    {
        public Vector3 TourneTourne;

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(TourneTourne * Time.deltaTime);
        }
    


}


