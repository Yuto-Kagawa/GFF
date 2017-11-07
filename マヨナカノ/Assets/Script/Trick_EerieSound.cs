using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trick_EerieSound : MonoBehaviour
{
    public Vector3  PlayerPos;//主人公の現在いる位置を入れる変数
    public AudioSource EerieSound;//不気味な音
    int SoundFagCount;//音を流すためのカウント(1の時は流す、それ以外は流さない)

	void Start ()
    {
        EerieSound = GetComponent<AudioSource>();//音を取得
        SoundFagCount = 0;
	}

	void Update ()
    {    
        PlayerPos = transform.position;//変数PlayerPosに現在の位置を代入する

        if (PlayerPos.x > 30 && PlayerPos.z > 50)//主人公の位置がX=30,Z=50なら
        {
            Debug.Log("不気味な音流す");
            SoundFagCount += 1;//カウントを足す
        }

        if (SoundFagCount == 1)
        {
            EerieSound.PlayOneShot(EerieSound.clip);//不気味な音を再生
            SoundFagCount += 1;//カウントを増やし以降は流さない
        }
	}
}
