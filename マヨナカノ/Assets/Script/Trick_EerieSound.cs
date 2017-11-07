using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trick_EerieSound : MonoBehaviour {

    Vector3  PlayerPos;//主人公の現在いる位置を入れる変数
    public AudioSource EerieSound;

    

	//Use this for initialization
	void Start () {
        EerieSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
      
        PlayerPos = transform.position;

        if(PlayerPos.x>30||PlayerPos.z>50)
        {
            Debug.Log("不気味な音流す");
            EerieSound.PlayOneShot(EerieSound.clip);
        }
	}
}
