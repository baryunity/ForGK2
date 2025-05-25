using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2.0f;

    void Start()
    {
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.Alpha0)) {
            Vector3 newPos = new Vector3(0f, 1.5f, 0f);
            transform.position = newPos;
        }
        else if (Input.GetKey(KeyCode.U))
        {
            transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.J))
        {
            transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
        }
        else
        {
            float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            float yValue = 0;
            float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            transform.Translate(xValue, yValue, zValue);
        }
    }
}
