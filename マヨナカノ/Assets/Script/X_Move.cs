using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X_Move : MonoBehaviour
{
    public float vector = 1;

	void Start ()
    {
		
	}

	void Update ()
    {
        //物体Xの移動条件
        //今はキー入力で回しているので条件文を変更する
        if (Input.GetKeyDown(KeyCode.Z)|| Input.GetKeyDown(KeyCode.X))
        {
            this.transform.position += new Vector3(0, 0, -1);
        } 
        
              
	}
}
