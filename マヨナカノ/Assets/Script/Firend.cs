using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firend : MonoBehaviour
{
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
    }
}

