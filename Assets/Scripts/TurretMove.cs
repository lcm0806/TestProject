using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMove : MonoBehaviour
{
    [SerializeField] float rotateSpeed;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }
}
