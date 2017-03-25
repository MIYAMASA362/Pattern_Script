using UnityEngine;
using System.Collections;

public class Player_Status : MonoBehaviour {

    //Playerのレベル
    public int PLAYER_LEVEL;
    public static int Player_Level;

    //HPの初期値・上限値
    public int PLAYER_HP;
    public static int Player_HP;

    //MPの初期値・上限値
    public int PLAYER_MP;
    public static int Player_MP;

    public static bool SKILL_MOVE;
    public static int SKILL_IN;

    //攻撃力と魔力
    public static int PLAYER_ATTACK_POINT;
    public static int PLAYER_MAGIC_POINT;

    //動作制限
    public static bool PLAYER_BOOL;

    //時間
    private float TIME;

    //魔力が無い
    public static bool MP_NOTING;

    //生死判定
    public static bool PLAYER_LIVE;

	void Start () {

        Player_Level = PLAYER_LEVEL;
        Player_HP = PLAYER_HP;
        Player_MP = PLAYER_MP;

        SKILL_MOVE = false;

        PLAYER_BOOL = false;

        PLAYER_LIVE = true;

        TIME = 0;

	}
	
	// Update is called once per frame
	void Update () {

        

        //MP時間回復
        if (Player_MP < PLAYER_MP)
        {
            TIME = TIME + Time.deltaTime;

            if (TIME >= 2.0f)
            {
                Player_MP = Player_MP + 1;

                TIME = 0;
            }
        }
        

        //MPが無くなった
        if (Player_MP <= 0)
        {
            MP_NOTING = true;

            Player_MP = 0;
        }
        else
        {
            MP_NOTING = false;
        }

        //限度を超えないように
        if (Player_HP >= PLAYER_HP)
        {
            Player_HP = PLAYER_HP;
        }
        if (Player_MP >= PLAYER_MP)
        {
            Player_MP = PLAYER_MP;
        }

        //スキルを発動した
        if (SKILL_MOVE == true)
        {
            Player_MP = Player_MP - PLAYER_MAGIC_POINT;

            Enemy_Status.ENEMY_BOOL = true;

            SKILL_MOVE = false;
        }

        if (PLAYER_BOOL == true)
        {
            Player_HP = Player_HP - Enemy_Status.ENEMY_ATTACK_POINT;

            PLAYER_BOOL = false;
        }

        //生死判定
        if (Player_HP <= 0)
        {
            PLAYER_LIVE = false;

            Player_HP = 0;
        }

        //Debug.Log("MP" + Player_MP);
    }
}
