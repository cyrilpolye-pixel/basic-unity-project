using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cameracontroller : MonoBehaviour
{
        public Rigidbody rb1;


private void  FixedUpdate()
    {
        rb1.AddForce(Vector3.forward * 100f * Time.fixedDeltaTime);

    }











}
