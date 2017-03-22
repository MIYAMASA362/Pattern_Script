using UnityEngine;
using System.Collections;

public class Player_Status : MonoBehaviour {

    //HPの初期値・上限値
    public int PLAYER_HP;
    public static int Player_HP;

    //MPの初期値・上限値
    public int PLAYER_MP;
    public static int Player_MP;

    public static bool SKILL_MOVE;
    public static int SKILL_IN;

    //スキルより割り出された攻撃力と魔力
    public static int ATTACK_POINT;
    public static int MAGIC_POINT;

    //動作制限
    public static bool PLAYER_BOOL;

    //時間
    private float TIME;

    //魔力が無い
    public static bool MP_NOTING;

	void Start () {

        Player_HP = PLAYER_HP;
        Player_MP = PLAYER_MP;

        SKILL_MOVE = false;

        TIME = 0;

	}
	
	// Update is called once per frame
	void Update () {

        TIME = TIME + Time.deltaTime;

        //MP回復
        if (TIME >= 2.0f)
        {
            Player_MP = Player_MP + 1;

            TIME = 0;
        }

        //MPが無くなった
        if (Player_MP <= 0)
        {
            MP_NOTING = true;
        }
        else
        {
            MP_NOTING = false;
        }

        //上限を超えないように
        if (Player_HP >= PLAYER_HP)
        {
            Player_HP = PLAYER_HP;
        }
        if (Player_MP >= PLAYER_MP)
        {
            Player_MP = PLAYER_MP;
        }

        if (SKILL_MOVE == true)
        {
            Debug.Log("消費された魔力:" + MAGIC_POINT);
            Debug.Log("敵に与えたダメージ:" + ATTACK_POINT);

            Player_MP = Player_MP - MAGIC_POINT;

            SKILL_MOVE = false;
        }

        Debug.Log("MP" + Player_MP);
    }
}
