using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class List_Conversion : MonoBehaviour {

    //変換したINT型を収集するリスト
    public static List<int> FRONT_INT_LIST = new List<int>();

    //抑制真偽値
    private bool TP1_1_BOOL;
    private bool TP1_2_BOOL;
    private bool TP1_3_BOOL;
    private bool TP2_1_BOOL;
    private bool TP2_2_BOOL;
    private bool TP2_3_BOOL;
    private bool TP3_1_BOOL;
    private bool TP3_2_BOOL;
    private bool TP3_3_BOOL;

	void Start () {

        TP1_1_BOOL = true;
        TP1_2_BOOL = true;
        TP1_3_BOOL = true;
        TP2_1_BOOL = true;
        TP2_2_BOOL = true;
        TP2_3_BOOL = true;
        TP3_1_BOOL = true;
        TP3_2_BOOL = true;
        TP3_3_BOOL = true;
    }
	
	void Update () {

        if (Core_Touching.RESET_TP == true)
        {
            TP1_1_BOOL = true;
            TP1_2_BOOL = true;
            TP1_3_BOOL = true;
            TP2_1_BOOL = true;
            TP2_2_BOOL = true;
            TP2_3_BOOL = true;
            TP3_1_BOOL = true;
            TP3_2_BOOL = true;
            TP3_3_BOOL = true;

            FRONT_INT_LIST.Clear();
        }

//Core_Touching.Touch_List内の要素を取り出しFRONT_INT_LISTにint型で変換する機構

        for (int i = 0; i < Core_Touching.Touch_List.Count; i++)
        {
            string j = Core_Touching.Touch_List[i];

            switch (j)
            {
                
                case "Tp1-1":

                    if (TP1_1_BOOL == true)
                    {
                        //Debug.Log("Tp1-1を検出");

                        FRONT_INT_LIST.Add(1);

                        TP1_1_BOOL = false;
                    }

                    break;

                case "Tp1-2":

                    if (TP1_2_BOOL == true)
                    {
                        //Debug.Log("Tp1-2を検出");

                        FRONT_INT_LIST.Add(2);

                        TP1_2_BOOL = false;
                    }

                    break;

                case "Tp1-3":

                    if (TP1_3_BOOL == true)
                    {
                        FRONT_INT_LIST.Add(3);

                        TP1_3_BOOL = false;
                    }

                    break;

                case "Tp2-1":

                    if (TP2_1_BOOL == true)
                    {
                        FRONT_INT_LIST.Add(4);

                        TP2_1_BOOL = false;
                    }

                    break;

                case "Tp2-2":

                    if (TP2_2_BOOL == true)
                    {
                        FRONT_INT_LIST.Add(5);

                        TP2_2_BOOL = false;
                    }

                    break;

                case "Tp2-3":

                    if (TP2_3_BOOL == true)
                    {
                        FRONT_INT_LIST.Add(6);

                        TP2_3_BOOL = false;
                    }

                    break;

                case "Tp3-1":

                    if (TP3_1_BOOL == true)
                    {
                        FRONT_INT_LIST.Add(7);

                        TP3_1_BOOL = false;
                    }

                    break;

                case "Tp3-2":

                    if (TP3_2_BOOL == true)
                    {
                        FRONT_INT_LIST.Add(8);

                        TP3_2_BOOL = false;
                    }

                    break;

                case "Tp3-3":

                    if (TP3_3_BOOL == true)
                    {
                        FRONT_INT_LIST.Add(9);

                        TP3_3_BOOL = false;

                    }

                    break;
            }

        }

/////////////////////////////////////////////////////////////////////////////////

        for (int i = 0; i < FRONT_INT_LIST.Count; i++)
        {
            //Debug.Log(FRONT_INT_LIST[i]);
            //Debug.Log(FRONT_INT_LIST[0] + "" + FRONT_INT_LIST[1]+""+FRONT_INT_LIST[2]);
        }
        
    }
}
