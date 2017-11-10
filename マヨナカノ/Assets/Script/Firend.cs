using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firend : MonoBehaviour
{
    public new Trick_Light light;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        GameObject player = GameObject.Find("Player");//ターゲットとなるオブジェクト
        float speed = 2.0f;//速さ
        float step = Time.deltaTime * speed;//
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);//Vector3.MoveTowards:二点間の特定の位置を返す
                                                                                                      //　　　　　　　　　　　（主人公と友人）
        //友人の消去（懐中電灯の光が消えたとき）
        //Trick_Light.csのFlashLightFlagの状態を見る
        if(light.FlashLightFlag==true)
        {
            gameObject.SetActive(false);//オブジェクトを非アクティブにする
        }

    }
}

