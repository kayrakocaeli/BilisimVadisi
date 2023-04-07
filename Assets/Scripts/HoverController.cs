using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverController : MonoBehaviour
{
   public List<GameObject> sprinngs;
   public Rigidbody rb;
   public GameObject prop;
   public GameObject CM;
    public float height=4f;

    private void Start()
    {
        rb.centerOfMass =CM.transform.localPosition;
    }
    private void Update()
    {
        ForceControl();
    }
    private void FixedUpdate()
    {
        HoverControl();
    }
    private void HoverControl()
    {
        rb.AddForceAtPosition(Time.deltaTime * transform.TransformDirection(Vector3.forward) * Input.GetAxis("Vertical") * 1100f, prop.transform.position);
        rb.AddTorque(Time.deltaTime * transform.TransformDirection(Vector3.up) * Input.GetAxis("Horizontal") * 300f);
        foreach (GameObject spring in sprinngs)
        {
            RaycastHit hit;
            if (Physics.Raycast(spring.transform.position, transform.TransformDirection(Vector3.down), out hit, height))
            {
                rb.AddForceAtPosition(Time.deltaTime * transform.TransformDirection(Vector3.up) * Mathf.Pow(height - hit.distance, 2f) / 3f * 500f, spring.transform.position);
            }
            Debug.Log(hit.distance);
        }
        rb.AddForce(-Time.deltaTime * transform.TransformVector(Vector3.right) * transform.InverseTransformVector(rb.velocity).x * 5f);
    }
    private void ForceControl()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (height<=10)
            {
                height += 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (height >=5)
            {
                height -= 1;
            }
        }
    }
}