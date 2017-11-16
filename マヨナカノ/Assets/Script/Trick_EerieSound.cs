using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trick_EerieSound : MonoBehaviour
{
    public AudioSource EerieSound;//不気味な音
    public bool SoundFlag;

	void Start ()
    {
        SoundFlag = false;
	}

	void Update ()
    {
        if (SoundFlag == true)
        {
            EerieSound.PlayOneShot(EerieSound.clip);//不気味な音を再生
        }
    }
}
