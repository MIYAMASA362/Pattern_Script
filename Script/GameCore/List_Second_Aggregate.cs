﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class List_Second_Aggregate : MonoBehaviour {
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.Return)||Input.GetMouseButtonDown(1))
        {
			
            Debug.Log("Enter");

            bool AGREEMENT_BOOL = false;

            for (int i = 0; i < Pattern_List.SKILL_LIST.Count; i++)
            {
                if (List_First_Aggregate.PATTERN_FINAL_LIST.SequenceEqual(Pattern_List.SKILL_LIST[i]))
                {
                    if (Player_Status.Player_MP >= Pattern_List.SKILL_INFO[i][0])
                    {
                        //スキルテキストの表示
                        Debug.Log("型:" + Pattern_List.SKILL_TEXT[i][0] + ", 魔力:" + Pattern_List.SKILL_INFO[i][0] + ", 攻撃力:" + Pattern_List.SKILL_INFO[i][1]);

                        Player_Status.SKILL_MOVE = true;

                        //Player.Statusへの値
                        Player_Status.PLAYER_MAGIC_POINT = Pattern_List.SKILL_INFO[i][0];
                        Player_Status.PLAYER_ATTACK_POINT = Pattern_List.SKILL_INFO[i][1];

                        AGREEMENT_BOOL = true;
                    }
                    else
                    {
                        Debug.Log("魔力が不足");
                    }

                }
            }

            if (AGREEMENT_BOOL == false)
            {
                Debug.Log("不発");
            }

            List_First_Aggregate.PATTERN_FINAL_LIST.Clear();
        }
	
	}
}
