using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour {

    public bool Attack;

    private float TIME;

    public static bool SKILL_MOVE;

	void Start () {

        SKILL_MOVE = false;

        Attack = false;

        TIME = 0;
		
	}

	void Update () {

        TIME = TIME + Time.deltaTime;

        //攻撃に必要な基本情報
        if (Attack == true)
        {
            SKILL_MOVE = true;

            Enemy_Status.ENEMY_ATTACK_POINT = 1;

            Enemy_Status.ENEMY_MAGIC_POINT = 10;

            Pattern_Count.Pattern_Rock = 5;

            Player_Status.PLAYER_BOOL = true;
        }
        else
        {
            Pattern_Count.Pattern_Rock = 0;
        }
	}
}
