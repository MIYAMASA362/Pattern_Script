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

	void Start () {

        Player_HP = PLAYER_HP;
        Player_MP = PLAYER_MP;

        SKILL_MOVE = false;

	}
	
	// Update is called once per frame
	void Update () {

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

        //Debug.Log("S_I:"+SKILL_IN);

        //Debug.Log("S_M:" +SKILL_MOVE);
    }
}
