using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToCheckPoint : MonoBehaviour
{
    Vector3 CurrentCheckPoint;
    CheckPointManager checkpoint;
    void Start()
    {
        CurrentCheckPoint = checkpoint.CheckPoint;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = CurrentCheckPoint;
        }
    }
}
