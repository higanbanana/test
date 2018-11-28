using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTrig : MonoBehaviour
{

    public Vector3 rpoint = Vector3.zero;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    /*private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("weewoo", gameObject);
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("weewoo", gameObject);
            other.transform.position = rpoint;
        }
    }
}
