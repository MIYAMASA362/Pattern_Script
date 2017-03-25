using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Pattern_Count : MonoBehaviour {

    public Material Default_Color;
    public Material In_Color;
    public Material Not_Color;

    public int Pattern_Rock;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Caseを取得する
        GameObject Case_1 = GameObject.Find("Case_1");
        GameObject Case_2 = GameObject.Find("Case_2");
        GameObject Case_3 = GameObject.Find("Case_3");
        GameObject Case_4 = GameObject.Find("Case_4");
        GameObject Case_5 = GameObject.Find("Case_5");

        //Case_1
        if (Pattern_Rock < 5)
        {
            if (List_First_Aggregate.PATTERN_FINAL_LIST.Count == 0)
            {
                //Defult_Color
                Case_1.GetComponent<Renderer>().material = Default_Color;
            }
            else if(List_First_Aggregate.PATTERN_FINAL_LIST.Count >= 1)
            {
                //In_Color
                Case_1.GetComponent<Renderer>().material = In_Color;
            }
        }
        else if (Pattern_Rock >= 5)
        {
            //Not_Color
            Case_1.GetComponent<Renderer>().material = Not_Color;

            if (List_First_Aggregate.PATTERN_FINAL_LIST.Count >= 1)
            {
                //RemoveAt(1)
                List_First_Aggregate.PATTERN_FINAL_LIST.RemoveAt(0);
            }
        }

        //Case_2
        if (Pattern_Rock < 4)
        {
            if (List_First_Aggregate.PATTERN_FINAL_LIST.Count == 0)
            {
                Case_2.GetComponent<Renderer>().material = Default_Color;
            }
            else if (List_First_Aggregate.PATTERN_FINAL_LIST.Count >= 2)
            {
                Case_2.GetComponent<Renderer>().material = In_Color;
            }
        }
        else if (Pattern_Rock >= 4)
        {
            Case_2.GetComponent<Renderer>().material = Not_Color;

            if (List_First_Aggregate.PATTERN_FINAL_LIST.Count >= 2)
            {
                List_First_Aggregate.PATTERN_FINAL_LIST.RemoveAt(1);
            }
        }

        //Case_3
        if (Pattern_Rock < 3)
        {
            if (List_First_Aggregate.PATTERN_FINAL_LIST.Count == 0)
            {
                Case_3.GetComponent<Renderer>().material = Default_Color;
            }
            else if (List_First_Aggregate.PATTERN_FINAL_LIST.Count >= 3)
            {
                Case_3.GetComponent<Renderer>().material = In_Color;
            }
        }
        else if (Pattern_Rock >= 3)
        {
            Case_3.GetComponent<Renderer>().material = Not_Color;

            if (List_First_Aggregate.PATTERN_FINAL_LIST.Count >= 3)
            {
                List_First_Aggregate.PATTERN_FINAL_LIST.RemoveAt(2);
            }
        }

        //Case_4
        if (Pattern_Rock < 2)
        {
            if (List_First_Aggregate.PATTERN_FINAL_LIST.Count == 0)
            {
                Case_4.GetComponent<Renderer>().material = Default_Color;
            }
            else if (List_First_Aggregate.PATTERN_FINAL_LIST.Count >= 4)
            {
                Case_4.GetComponent<Renderer>().material = In_Color;
            }
        }
        else if (Pattern_Rock >= 2)
        {
            Case_4.GetComponent<Renderer>().material = Not_Color;

            if (List_First_Aggregate.PATTERN_FINAL_LIST.Count >= 4)
            {
                List_First_Aggregate.PATTERN_FINAL_LIST.RemoveAt(3);
            }
        }

        //Case_5
        if (Pattern_Rock < 1)
        {
            if (List_First_Aggregate.PATTERN_FINAL_LIST.Count == 0)
            {
                Case_5.GetComponent<Renderer>().material = Default_Color;
            }
            else if (List_First_Aggregate.PATTERN_FINAL_LIST.Count >= 5)
            {
                Case_5.GetComponent<Renderer>().material = In_Color;
            }
        }
        else if (Pattern_Rock >= 1)
        {
            Case_5.GetComponent<Renderer>().material = Not_Color;

            if (List_First_Aggregate.PATTERN_FINAL_LIST.Count >= 5)
            {
                List_First_Aggregate.PATTERN_FINAL_LIST.RemoveAt(4);
            }
        }
    }
}
