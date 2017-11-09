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

        //if (X_Pos.z <= 35)
        //{
        //    Destroy(gameObject);
        //    Debug.Log("物体X消去");
        //}
    }
}
