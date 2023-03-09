using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigidbody.AddForce(transform.up * m_Thrust);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_Rigidbody.AddForce(transform.left * m_Thrust);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_Rigidbody.AddForce(transform.right * m_Thrust);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_Rigidbody.AddForce(transform.back * m_Thrust);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_Rigidbody.AddForce(transform.forward * m_Thrust);
        }
    }
}
