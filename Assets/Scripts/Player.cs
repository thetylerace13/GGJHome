﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody m_rigidBody;
    [SerializeField]
    private float m_speed;
    [SerializeField]
    private GameObject m_feet;
    private float m_jumpForce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        m_rigidBody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("Space was hit");
            Jump();
        }
    }

    void Move()
    {
        m_rigidBody.MovePosition(this.m_rigidBody.position + transform.forward * Input.GetAxis("Vertical") * Time.fixedDeltaTime * m_speed);
        m_rigidBody.MovePosition(this.m_rigidBody.position + transform.right * Input.GetAxis("Horizontal") * Time.fixedDeltaTime * m_speed);
    }

    void Jump()
    {
        bool hit = Physics.Raycast(this.m_feet.transform.position, Vector3.down, 1f);
        //Debug.DrawRay(this.m_feet.transform.position, Vector3.down, Color.green, 2f);
        if(hit)
        {
            m_rigidBody.AddForce(Vector3.up * m_jumpForce, ForceMode.VelocityChange);
            Debug.Log("There was a hit");
        }
    }
}
