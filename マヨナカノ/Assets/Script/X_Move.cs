using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X_Move : MonoBehaviour {

    public float vector = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Z)|| Input.GetKeyDown(KeyCode.X))
        {
            this.transform.position += new Vector3(0, 0, -1);
        }
           
	}
}
