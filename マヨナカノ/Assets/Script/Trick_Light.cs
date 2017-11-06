using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trick_Light : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("DestroyWin", 1000f);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Destroy(gameObject);
        }
	}
}
