using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {

    private Transform mTransform;

    public float speed = 6f;

	// Use this for initialization
	void Start ()
    {
        mTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKey(KeyCode.W))
        {
            mTransform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            mTransform.Translate(new Vector3(0, -speed, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            mTransform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            mTransform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jeep"))
        {
            Vector3 newPos = new Vector3(-20, 3, -1);
            mTransform.transform.position = newPos;
        }
    }

}
