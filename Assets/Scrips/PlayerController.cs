using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float speed = 5f;

    [SerializeField]
    float looksensi = 5f;


    PlayerMotor motor;

    void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        float xmov = Input.GetAxisRaw("Horizontal");
        float zmov = Input.GetAxisRaw("Vertical");

        Vector3 movhori = transform.right * xmov;
        Vector3 movver = transform.forward * zmov;

        Vector3 velo = ((movhori) + (movver)).normalized * speed;


        motor.Move(velo);

        float yRot = Input.GetAxisRaw("Mouse X");

        Vector3 rotation = new Vector3(0f, yRot, 0f) * looksensi;

        motor.Rotate(rotation);

        float xRot = Input.GetAxisRaw("Mouse Y");

        Vector3 camrotation = new Vector3(xRot, 0f, 0f) * looksensi;
       // Debug.Log(xRot);

        motor.Camrotate(camrotation );
    }
   
}
