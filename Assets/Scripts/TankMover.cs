using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;
    private void Update()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        float input = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * moveSpeed * input * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
    }

    private void Rotate()
    {
        float input = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, rotateSpeed * input * Time.deltaTime);
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        //}
    }
}
