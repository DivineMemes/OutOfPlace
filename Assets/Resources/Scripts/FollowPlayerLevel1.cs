using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerLevel1 : MonoBehaviour
{
    public GameObject player;

	void Start ()
    {
		
	}
	
	
	void Update ()
    {
       gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, player.transform.position.z);
	}
}
