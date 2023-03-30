using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverController1 : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float responsivness = 500f;
    [SerializeField] private float throttleAmt = 500f;
   
    private float throttle;

    private float roll;
    private float pitch;
    private float yaw;

    private void Awake()
    {
        rb= GetComponent<Rigidbody>();
    }
    private void Update()
    {
        HandleInputs();
        
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(transform.up*throttle,ForceMode.Impulse);
        GetComponent<Rigidbody>().AddTorque(transform.right * pitch * responsivness);
        GetComponent<Rigidbody>().AddTorque(-transform.forward * roll * responsivness);
        GetComponent<Rigidbody>().AddTorque(transform.up* yaw * responsivness);
    }
    private void HandleInputs()
    {
        roll = Input.GetAxis("Horizontal");
        pitch = Input.GetAxis("Vertical");
        yaw = Input.GetAxis("Yaw");

        if (Input.GetKey(KeyCode.Space))
        {
            throttle += Time.deltaTime * throttleAmt;
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            throttle -= Time.deltaTime * throttleAmt;
        }
        throttle = Mathf.Clamp(throttle,0f,100f);
    }
}
