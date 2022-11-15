using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMOvement : MonoBehaviour
{
    Rigidbody body;
    public Vector2 input;
    [SerializeField] float speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            input.y = 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            input.y = -1;
        }
        if (Input.GetKey(KeyCode.W))
        {
            input.x = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            input.x = -1;
        }
        Vector3 torque = new Vector3(input.x, 0, input.y);
        body.AddTorque(torque * speed * Time.fixedDeltaTime);
    }
}
