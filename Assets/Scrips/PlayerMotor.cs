using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{

    Vector3 velocity = Vector3.zero ;
    Vector3 rotation = Vector3.zero;
    Vector3 camrotation = Vector3.zero;

    bool flag = false ;

    [SerializeField]
    private Camera cam;
    public Rigidbody rb;

    void Start()
    {
        //rb.GetComponent<Rigidbody>();
        flag = false;

       // Debug.Log("Zero");


    }
    public void Move(Vector3 velo)
    {
        velocity = velo;

    }

    void FixedUpdate()
    {
        performMovement();
        PerformRotate();
    }
    void performMovement()
    {
        if(velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.deltaTime);
        }
    }
    public void Camrotate(Vector3 crot)
    {
        camrotation = crot;
    }
    public void Rotate(Vector3 rot)
    {
        rotation = rot;
    }

    void PerformRotate()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
        if (cam != null)
        {
            if (flag == false)
                flag = true;
            else
            Invoke("LateR", 2f);
        }
    }

    void LateR()
    {
        cam.transform.Rotate(-camrotation);
    }

}
