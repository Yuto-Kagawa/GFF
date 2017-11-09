using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X_Move : MonoBehaviour
{
    Vector3 PlayerPos;
    Vector3 X_Pos;
    public bool XFlag;

	void Start ()
    {
        XFlag = false;
	}

	void Update ()
    {
        X_Pos = transform.position;//物体Xの現在の位置を代入する   

        if (XFlag == true)
        {
            transform.position += new Vector3(0, 0, -30)*Time.deltaTime;//Xというオブジェクトを移動させる
                                                                        //daltaTime:異なった実行環境での見た目上の移動速度を一定にする
            if (transform.position.z < 35)
            {
               gameObject.SetActive(false);//オブジェクトを非アクティブにする
            }
        }
    }
}
