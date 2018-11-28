using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour {

    public float mSpeed;	
	
	void Update ()
    {
        //transform.Translate(mSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, mSpeed * Input.GetAxis("Jump") * (Time.deltaTime/10f), mSpeed * Input.GetAxis("Vertical") * (Time.deltaTime));
	}
}
