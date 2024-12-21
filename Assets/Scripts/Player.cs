using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;

    public float speed;

    private bool isGrounded;
    private float jumpForce = 20f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction.x = 1;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction.x = -1;
        }

        _rb.MovePosition(_rb.position + direction * speed * Time.deltaTime);
    }
}
