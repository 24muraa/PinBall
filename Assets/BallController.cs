using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {
    //ボールが見える可能性のあるZ軸の最大値
    private float vesiblePosZ =- 6.5f;

    //オームオーバーを表示するテキスト
    private GameObject gameoverText;
    public Text scoerText;
    int n;

	// Use this for initialization
	void Start () {
        //シーン内のGameOvreTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
	}
	
	// Update is called once per frame
	void Update () {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.vesiblePosZ)
        {
            //GameoverTextにゲームオーバーを表示
            this.gameoverText.GetComponent<Text>().text = "GameOver";
        }
	}
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag== "LargeCloudTag")
        {
            n += 20;
            scoerText.text = " "+n;
        }
        if(other.gameObject.tag== "LargeStarTag")
        {
            n += 20;
            scoerText.text = "" + n;
        }
        if(other.gameObject.tag== "SmallCloudTag")
        {
            n += 10;
            scoerText.text = "" + n;
        }
        if(other.gameObject.tag== "SmallStarTag")
        {
            n += 10;
            scoerText.text = "" + n;
        }
    }
}
