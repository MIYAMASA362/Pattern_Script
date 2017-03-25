using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Status : MonoBehaviour {

    //HPの初期値・上限値
    public int ENEMY_HP;
    public static int Enemy_HP;

    //MPの初期値・上限値
    public int ENEMY_MP;
    public static int Enemy_MP;

    //攻撃力と魔力
    public static int ENEMY_ATTACK_POINT;
    public static int ENEMY_MAGIC_POINT;

    private float TIME;

    //動作制限
    public static bool ENEMY_BOOL;

    //生死判定
    public static bool ENEMY_LIVE;

	void Start () {

        Enemy_HP = ENEMY_HP;
        Enemy_MP = ENEMY_MP;

        TIME = 0;

        ENEMY_LIVE = true;

        ENEMY_BOOL = false;

	}
	
	// Update is called once per frame
	void Update () {

        //基本処理
        TIME = TIME + Time.deltaTime;

        if (TIME >= 2.0f)
        {
            Enemy_MP = Enemy_MP + 1;

            TIME = 0;
        }

        if (Enemy_MP >= ENEMY_MP)
        {
            Enemy_MP = ENEMY_MP;
        }

        if (Enemy_HP >= ENEMY_HP)
        {
            Enemy_HP = ENEMY_HP;
        }

        //ダメージ処理
        if (ENEMY_BOOL == true)
        {
            Enemy_HP = Enemy_HP - Player_Status.PLAYER_ATTACK_POINT;

            ENEMY_BOOL = false;
        }

        //生死判定
        if (Enemy_HP <= 0)
        {
            ENEMY_LIVE = false;

            Enemy_HP = 0;
        }
	}
}
