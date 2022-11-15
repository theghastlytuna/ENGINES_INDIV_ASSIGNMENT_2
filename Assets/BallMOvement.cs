using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMOvement : MonoBehaviour
{
    Rigidbody body;
    public Vector2 input;
    [SerializeField] float speed = 1000;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Quaternion deviceRotation = Input.gyro.attitude;
        //Debug.Log(deviceRotation);

        //transform.rotation = deviceRotation;

        Vector3 Device = deviceRotation.eulerAngles;
        Debug.Log(Device);

        //float Inputx = Mathf.Lerp(0f, 1f, Device.x / 90);
        
        input.y = Device.y - 180;
        input.x = Device.x - 180;
       
        Vector3 torque = new Vector3(input.x, 0, input.y);
        body.AddTorque(torque * speed * Time.fixedDeltaTime);
    }
}
