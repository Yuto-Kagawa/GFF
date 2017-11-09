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
        PlayerPos = transform.position;             //変数PlayerPosに現在の位置を代入する
        GameObject X = GameObject.FindGameObjectWithTag("X");//"X"というタグを付けているオブジェクトを探す
        //仕掛け1
        //不気味な音を流す
        if (PlayerPos.x > 47 && PlayerPos.z > 50)   //主人公の位置がX=30,Z=50なら
        {
            Debug.Log("不気味な音流す");
            SoundFagCount += 1;                     //カウントを足す
        }

        if (SoundFagCount == 1)
        {
            EerieSound.PlayOneShot(EerieSound.clip);//不気味な音を再生
            SoundFagCount += 1;                     //カウントを増やし以降は流さない
        }

        //仕掛け2
        //物体Xが前を通る
        if (PlayerPos.x > 100)//主人公がX座標＞100なら
        {
            Debug.Log("フラグを変更");
            //X_Count += 1;
            X_Flag = true;
        }
        if (X_Flag==true)
        {
            Debug.Log("物体X移動開始");
           // GameObject X = GameObject.FindGameObjectWithTag("X");//"X"というタグを付けているオブジェクトを探す
            X.transform.position += new Vector3(0, 0, -1);       //"X"のタグが付いているオブジェクトを移動させる
           // X_Count += 1;                                        //カウントを足す
        }
        //if (X.transform.position.z <= 35)s
        //{
        //    Destroy(X);
        //    Debug.Log("物体X消去");
        //}

        //仕掛け3
        //懐中電灯の光が消える
        //友人が消える
        if (PlayerPos.x > 150)
        {
            if (FlashLightDeleteTime < 10)
            {
                GameObject FlashLight = GameObject.FindGameObjectWithTag("FlashLight");//"FlashLight"というタグを付けているオブジェクトを探す
                Destroy(FlashLight);//"FlashLight"がついているオブジェクトを削除
                Debug.Log("光消去");
                FlashLightDeleteTime += 1;
            }
            else
            {
                GameObject FlashLight = GameObject.FindGameObjectWithTag("FlashLight");//"FlashLight"というタグを付けているオブジェクトを探す
               //Instantiate(FlashLight);
                Debug.Log("光再度");
            }
        }
    }
}

////仕掛け1
//void Trick_EerieSound()
//{
//    if (PlayerPos.x > 47 && PlayerPos.z > 50)//主人公の位置がX=30,Z=50なら
//    {
//        Debug.Log("不気味な音流す");
//        SoundFagCount += 1;//カウントを足す
//    }

//    if (SoundFagCount == 1)
//    {
//        EerieSound.PlayOneShot(EerieSound.clip);//不気味な音を再生
//        SoundFagCount += 1;//カウントを増やし以降は流さない
//    }
//}

//仕掛け2
//void X()
//{
//    X_Pos = X.transform.position;//物体Xの現在の位置を代入する   

//    if (X_Pos.z <= 35)
//    {
//        Destroy(gameObject);
//        Debug.Log("物体X消去");
//    }
//}