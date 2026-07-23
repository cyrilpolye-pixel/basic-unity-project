using UnityEngine;
using UnityEngine.InputSystem;

public class cuberunner : MonoBehaviour
{
    public Rigidbody rb;
public GameObject winp;
    private void FixedUpdate()
    {
        //move forward
        rb.AddForce(Vector3.forward * 100f * Time.fixedDeltaTime);
        if(Keyboard.current.aKey.isPressed)
        {
            //move left
            transform.position -= new Vector3(10f * Time.fixedDeltaTime, 0, 0);
        }
        else if(Keyboard.current.dKey.isPressed)
        {
            //move right
            transform.position += new Vector3(10f * Time.fixedDeltaTime, 0, 0);
        }


    }


private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "win")
        {
            winp.SetActive(true);
        }
    }















}