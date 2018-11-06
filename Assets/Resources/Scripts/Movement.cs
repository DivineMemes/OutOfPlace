using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    //Rigidbody rb;
    //public float speed;
    //public AnimationCurve accel;
    //public float accelEval;
    //public bool toggle;

    //Vector3 forwardDir;
    //Vector3 rightDir;

    //Transform camera;
    //void Start()
    //{
    //    camera = GetComponentInChildren<Camera>().transform;
    //    rb = GetComponent<Rigidbody>();
    //}

    //public void Slow()
    //{
    //    rb.velocity *= 0.5f;
    //}

    //void Update()
    //{

    //    float horz = Input.GetAxisRaw("Horizontal");
    //    float vert = Input.GetAxisRaw("Vertical");

    //    if (camera != null)
    //    {
    //        forwardDir = camera.transform.forward * vert;
    //        rightDir = camera.transform.right * horz * 0.5f;
    //        gameObject.transform.rotation = camera.transform.rotation;
    //    }
    //}

    //void FixedUpdate()
    //{
    //    if (camera != null)
    //    {

    //        Vector3 dir = (forwardDir + rightDir).normalized;
    //        Vector3 desiredVel = dir * (speed * accel.Evaluate(accelEval));
    //        rb.AddForce(desiredVel - rb.velocity);

    //        if (Input.GetAxisRaw("Horizontal").Equals(0) && Input.GetAxisRaw("Vertical").Equals(0))
    //        {
    //            rb.velocity = new Vector3(0, gameObject.GetComponent<Rigidbody>().velocity.y, 0);
    //        }
    //    }
    //}


    Rigidbody rb;
    public float speed;
    Vector3 forwardDir;
    Vector3 rightDir;
    Vector3 myForwardDir;

    //Vector3 CameraYrot;

    Transform Camera;
    void Start()
    {
        // Debug.Log(transform.childCount);
        // CameraX = this.gameObject.transform.GetChild(0);
        Camera = GetComponentInChildren<Camera>().transform;
        // Debug.Log(CameraX.transform.childCount);
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //Debug.Log((forwardDir + rightDir) * speed );
        //rb.AddForce((forwardDir + rightDir) * speed );
        rb.MovePosition(transform.position + (forwardDir + rightDir) * speed);
    }

    void Update()
    {
        float horz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        forwardDir = Camera.transform.forward * vert;
        rightDir = Camera.transform.right * horz;

        gameObject.transform.rotation = Camera.transform.rotation;


        // Debug.Log(horz + " " + vert);
        //GetComponent<Rigidbody>().MovePosition(transform.position + dirVector * Time.deltaTime);
    }
}