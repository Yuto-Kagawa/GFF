using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

    //public Timer time;
	//次のシーンの名前
	public  string nextScene;
    // Use this for initialization
    private static float margin = 2.0f;
	//遷移したかどうかを保存する変数
	bool Moved = false;

	void Start ()
    {
      //  AudioManager.Instance.PlayBGM("");
       // AudioManager.Instance.PlaySE("");
        //nextScene = null;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log (nextScene);
        if (!Moved)
        {
            switch (Application.loadedLevelName)
            {
                case "Title":
                    /*次のシーンに遷移する方法*/
				if (Input.GetKeyDown(KeyCode.Space))
                    {
                        ChangeScene();
                    }
                    break;
				case "Explanation":
				if (Input.GetMouseButton(0)) 
					{
						ChangeScene ();
					}
					break;
                case "Main":
                    /*次のシーンに遷移する方法*/
                    if (Input.GetMouseButton(0))
                    {
                        ChangeScene();
                    }
                    break;
                case "Gamever":
				if (Input.GetMouseButtonUp(0))
                    {
                        ChangeScene();
                    }
                    break;
                case "GameClear":
                    if (Input.GetMouseButtonUp(0))
                    {
                        ChangeScene();
                    }
                    break;
            }
        }
        if (nextScene == SceneManager.GetActiveScene().name)
        {
            //次のシーンをnull
            //nextScene = null;
            //Debug.Log(" null or NotNull:::" + nextScene);
            Moved = false;
        }
        /*	if ((nextScene != null) && (Moved == false))
            {
                Debug.Log ("nextScene name:::" + nextScene);
                Moved = true;
                //シーンの遷移
                FadeManager.Instance.LoadLevel (nextScene, 2.0f);

            }

            if(nextScene == SceneManager.GetActiveScene().name)
            {
                //次のシーンをnull
                nextScene = null;
                Debug.Log(" null or NotNull:::" + nextScene);
                Moved = false;
            }*/
    }
    public void ChangeScene() {
		FadeManager.Instance.LoadLevel(nextScene, 1.0f);
            Moved = true;        
    }
}
