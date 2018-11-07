using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    public Vector3 CheckPoint;
    void Awake()
    {
        CheckPoint = gameObject.transform.position;
    }

    public void GoToLastCheckpoint()
    {
        transform.position = CheckPoint;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "CheckPoint")
        {
            CheckPoint = collision.transform.position;
        }
    }
}
