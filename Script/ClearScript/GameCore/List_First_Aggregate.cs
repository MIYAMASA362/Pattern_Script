using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class List_First_Aggregate : MonoBehaviour {

    //パターンの種類を最終的にまとめたリスト
    public static List<int> PATTERN_FINAL_LIST = new List<int>();

    private bool PFLIST_OVER;

    void Update() {

        for (int i = 0; i < PATTERN_FINAL_LIST.Count; i++)
        {
            Debug.Log("要素"+i+":"+PATTERN_FINAL_LIST[i]);
        }

        //Debug.Log(PATTERN_FINAL_LIST.Count);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PATTERN_FINAL_LIST.Clear();
        }

        //リスト容量制限
        if (PATTERN_FINAL_LIST.Count >= 5)
        {
            PFLIST_OVER = true;

            Debug.Log("リストは満杯です");

            PATTERN_FINAL_LIST.RemoveAt(5);
        }
        else
        {
            PFLIST_OVER = false;
        }

///////////////////////////////////////////////////////////////////////////

        //左クリックが解除された時
        if (Core_Touching.MOVE_UP == true)
        {
            bool AGREEMENT_BOOL = false;

            for (int i = 0; i < Pattern_List.FIRST_PATTERN_LIST.Count; i++)
            {
                //リストの要素が等しいならば
                if (List_Conversion.FRONT_INT_LIST.SequenceEqual(Pattern_List.FIRST_PATTERN_LIST[i]))
                {

                    Debug.Log("合致. パターン:" + i);

                    PATTERN_FINAL_LIST.Add(i);

                    Core_Touching.RESET_TP = true;

                    AGREEMENT_BOOL = true;
                }
            }

            if (AGREEMENT_BOOL == false)
            {
                Debug.Log("不合致");

                Core_Touching.RESET_TP = true;
            }

            Core_Touching.MOVE_UP = false;
        }

    }
}
