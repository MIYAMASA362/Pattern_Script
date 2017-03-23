using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = "プレイヤー"+"\n"+
                                         "HP:"+Player_Status.Player_HP+"\n"+
                                         "MP:"+Player_Status.Player_MP+"\n"+
                                         "LIVE:"+Player_Status.PLAYER_LIVE+"\n"+
                                         "\n"+
                                         "エネミー"+"\n"+
                                         "HP:"+Enemy_Status.Enemy_HP+"\n"+
                                         "MP:"+Enemy_Status.Enemy_MP+"\n"+
                                         "LIVE:"+Enemy_Status.ENEMY_LIVE;
    }
}
