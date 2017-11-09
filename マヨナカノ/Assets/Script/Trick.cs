using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trick : MonoBehaviour
{
    Vector3 PlayerPos;              //主人公の現在の位置を入れる変数
    public AudioSource EerieSound;  //不気味な音
    int SoundFagCount;              //音を流すためのカウント(1の時は流す、それ以外は流さない)
    bool X_Flag;                    //物体Xを移動させるかどうか
    int FlashLightDeleteTime;       //懐中電灯の光を消してる時間

    public X_Move X;
    public Trick_Light FlashLight;

    // Use this for initialization
    void Start ()
    {
        EerieSound = GetComponent<AudioSource>();//音を取得
        SoundFagCount = 0;
        Invoke("DestroyWin", 1000f);
        X_Flag=false;
        FlashLightDeleteTime = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        PlayerPos = transform.position;                      //変数PlayerPosに現在の位置を代入する
        GameObject X = GameObject.FindGameObjectWithTag("X");//"X"というタグを付けているオブジェクトを探す
    }

    void OnTriggerEnter(Collider other)
    {
        //仕掛け1
        //不気味な音を流す
        if (other.gameObject.tag == "Trick_EerieSound")   //主人公の位置がX=30,Z=50なら
        {
            Debug.Log("不気味な音流す");
            EerieSound.PlayOneShot(EerieSound.clip);//不気味な音を再生
        }
        //仕掛け2
        //物体Xが前を通る
        else if (other.gameObject.tag=="Trick_X")
        { 
            Debug.Log("物体X移動開始");
            X.XFlag = true;
        }
        //仕掛け3
        //懐中電灯の光が消える
        //友人が消える
        else if (other.gameObject.tag == "Trick_Delete")
        {
            FlashLight.FlashLightFlag = true;
        }
    }

    
}


