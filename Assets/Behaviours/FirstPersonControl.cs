using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstPersonControl : MonoBehaviour
{
    public float Sensitivity = 50.0f;
    public float MovementSpeed = 20.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        UpdateDirection();
        UpdateMovement();
    }

    void UpdateMovement()
    {
        var dx = Input.GetAxis("Horizontal");
        var dy = Input.GetAxis("Vertical");


        var cameraForward = gameObject.transform.forward;

        var forwardMovement = new Vector3(cameraForward.x, 0, cameraForward.z) * dy;
        var strafeMovement = gameObject.transform.right * dx;

        gameObject.transform.position +=  (forwardMovement + strafeMovement) * MovementSpeed * Time.deltaTime;
    }

    void UpdateDirection()
    {
        var dx = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
        var dy = -Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

        var position = gameObject.transform.position;
        var rightAxis = gameObject.transform.right;

        gameObject.transform.RotateAround(position, rightAxis, dy);
        gameObject.transform.RotateAround(position, Vector3.up, dx);
    }
}
