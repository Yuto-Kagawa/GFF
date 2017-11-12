using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trick : MonoBehaviour
{
    Vector3 PlayerPos;              //主人公の現在の位置を入れる変数
    public AudioSource EerieSound;  //不気味な音
    int SoundFagCount;              //音を流すためのカウント(1の時は流す、それ以外は流さない)
    bool X_Flag;                    //物体Xを移動させるかどうか
    public X_Move X;
    int FlashLightDeleteTime;       //懐中電灯の光を消してる時間
    public Trick_Light FlashLight;  //Trick_LightクラスのGameObject FlashLightを継承
    public Stalker SK;

    bool GameOverFlag;
    // Use this for initialization
    void Start ()
    {
        EerieSound = GetComponent<AudioSource>();//音を取得
        SoundFagCount = 0;
        X_Flag=false;
        FlashLightDeleteTime = 0;
        GameOverFlag = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        PlayerPos = transform.position;//変数PlayerPosに現在の位置を代入する
    }

    void OnTriggerEnter(Collider other)
    {
        //仕掛け1
        //不気味な音を流す
        if (other.gameObject.tag == "Trick_EerieSound")   //タグ"Trick_EerieSound"に当たれば
        {
            //Debug.Log("不気味な音流す");
            EerieSound.PlayOneShot(EerieSound.clip);//不気味な音を再生
        }
        //仕掛け2
        //物体Xが前を通る
        else if (other.gameObject.tag=="Trick_X")//タグ"Trick_X"に当たれば
        { 
            //Debug.Log("物体X移動開始");
            X.XFlag = true;
        }
        //仕掛け3
        //懐中電灯の光が消える
        //友人が消える
        else if (other.gameObject.tag == "Trick_Delete")//タグ"Trick_Delete"に当たれば
        {
            FlashLight.FlashLightFlag = true; 
        }
        //仕掛け4
        //後ろからストーカー
        else if(other.gameObject.tag== "Trick_Stalker")
        {
            //Debug.Log("ストーカーグラぐ");
            SK.StalkerFlag = true;
            SK.gameObject.SetActive(true);
        }
        //ストーカーに当たればゲームオーバー
        else if(other.gameObject.tag=="Stalker")
        {
            //Debug.Log("ゲームオーバーフラグ");
            GameOverFlag = true;
            SceneManager.LoadScene("GameOver");
        }
        //ゲームクリアオブジェクトに当たればゲームクリア
        else if(other.gameObject.tag=="GameClear")
        {
            Debug.Log("ゲームクリア");
            SceneManager.LoadScene("GameClear");
        }
    }

    
}


