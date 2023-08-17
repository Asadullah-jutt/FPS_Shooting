using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdestroy : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    private void Start()
    {
        Debug.Log("dfgdfgdf");
     //   rb = GetComponent<Rigidbody>();
        // Set the target rotation to a specific angle around the Y-axis
       
      //  rb.AddForce(transform.forward * 300, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Player")
        {
            Debug.Log(collision.gameObject.name);
            Destroy(gameObject);
        }
    }
}
