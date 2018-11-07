using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToCheckPoint : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var man = collision.gameObject.GetComponent<CheckPointManager>();

            if (man != null)
            {
                man.GoToLastCheckpoint();
            }
        }
    }
}
