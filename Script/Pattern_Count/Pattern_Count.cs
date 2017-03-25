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



        switch (Pattern_Rock)
        {
            case 0:

                switch (List_First_Aggregate.PATTERN_FINAL_LIST.Count)
                {
                    case 0:

                        Case_1.GetComponent<Renderer>().material = Default_Color;
                        Case_2.GetComponent<Renderer>().material = Default_Color;
                        Case_3.GetComponent<Renderer>().material = Default_Color;
                        Case_4.GetComponent<Renderer>().material = Default_Color;
                        Case_5.GetComponent<Renderer>().material = Default_Color;

                        break;

                    case 1:

                        Case_1.GetComponent<Renderer>().material = In_Color;

                        break;

                    case 2:

                        Case_2.GetComponent<Renderer>().material = In_Color;

                        break;

                    case 3:

                        Case_3.GetComponent<Renderer>().material = In_Color;

                        break;

                    case 4:

                        Case_4.GetComponent<Renderer>().material = In_Color;

                        break;

                    case 5:

                        Case_5.GetComponent<Renderer>().material = In_Color;

                        break;
                }

                break;

            case 1:

                Case_5.GetComponent<Renderer>().material = Not_Color;
                
                switch (List_First_Aggregate.PATTERN_FINAL_LIST.Count)
                {
                    case 0:

                        Case_1.GetComponent<Renderer>().material = Default_Color;
                        Case_2.GetComponent<Renderer>().material = Default_Color;
                        Case_3.GetComponent<Renderer>().material = Default_Color;
                        Case_4.GetComponent<Renderer>().material = Default_Color;

                        break;

                    case 1:

                        Case_1.GetComponent<Renderer>().material = In_Color;

                        break;

                    case 2:

                        Case_2.GetComponent<Renderer>().material = In_Color;

                        break;

                    case 3:

                        Case_3.GetComponent<Renderer>().material = In_Color;

                        break;

                    case 4:

                        Case_4.GetComponent<Renderer>().material = In_Color;

                        break;

                    case 5:

                        List_First_Aggregate.PATTERN_FINAL_LIST.RemoveAt(5);

                        break;
                }
                break;

            case 2:

                Case_5.GetComponent<Renderer>().material = Not_Color;
                Case_4.GetComponent<Renderer>().material = Not_Color;

                switch (List_First_Aggregate.PATTERN_FINAL_LIST.Count)
                {
                    case 0:

                        Case_1.GetComponent<Renderer>().material = Default_Color;
                        Case_2.GetComponent<Renderer>().material = Default_Color;
                        Case_3.GetComponent<Renderer>().material = Default_Color;

                        break;

                    case 1:

                        Case_1.GetComponent<Renderer>().material = In_Color;

                        break;

                    case 2:

                        Case_2.GetComponent<Renderer>().material = In_Color;

                        break;

                    case 3:

                        Case_3.GetComponent<Renderer>().material = In_Color;

                        break;

                    case 4:

                        List_First_Aggregate.PATTERN_FINAL_LIST.RemoveAt(4);

                        break;

                    case 5:

                        List_First_Aggregate.PATTERN_FINAL_LIST.RemoveAt(5);

                        break;
                }

                break;
        }

        switch (List_First_Aggregate.PATTERN_FINAL_LIST.Count)
        {
            case 0 :

                    Case_1.GetComponent<Renderer>().material = Default_Color;
                    Case_2.GetComponent<Renderer>().material = Default_Color;
                    Case_3.GetComponent<Renderer>().material = Default_Color;
                    Case_4.GetComponent<Renderer>().material = Default_Color;
                    Case_5.GetComponent<Renderer>().material = Default_Color;

                break;

            case 1:

                if (Pattern_Rock >= 5)
                {
                    List_First_Aggregate.PATTERN_FINAL_LIST.RemoveAt(1);
                }
                else
                {
                    Case_1.GetComponent<Renderer>().material = In_Color;
                }

                break;

            case 2:

                if (Pattern_Rock >= 4)
                {
                    List_First_Aggregate.PATTERN_FINAL_LIST.RemoveAt(2);
                }
                else
                {
                    Case_2.GetComponent<Renderer>().material = In_Color;
                }

                break;

            case 3:

                if (Pattern_Rock >= 3)
                {
                    List_First_Aggregate.PATTERN_FINAL_LIST.RemoveAt(3);
                }
                else
                {
                    Case_3.GetComponent<Renderer>().material = In_Color;
                }

                break;

            case 4:

                if (Pattern_Rock >= 2)
                {
                    List_First_Aggregate.PATTERN_FINAL_LIST.RemoveAt(4);
                }
                else
                {
                    Case_4.GetComponent<Renderer>().material = In_Color;
                }

                break;

            case 5:

                if (Pattern_Rock >= 1)
                {
                    List_First_Aggregate.PATTERN_FINAL_LIST.RemoveAt(5);
                }
                else
                {
                    Case_5.GetComponent<Renderer>().material = In_Color;
                }

                break;
        }

        switch (Pattern_Rock)
        {
            case 1:

                Case_5.GetComponent<Renderer>().material = Not_Color;

                break;

            case 2:

                Case_4.GetComponent<Renderer>().material = Not_Color;
                Case_5.GetComponent<Renderer>().material = Not_Color;

                break;

            case 3:

                Case_3.GetComponent<Renderer>().material = Not_Color;
                Case_4.GetComponent<Renderer>().material = Not_Color;
                Case_5.GetComponent<Renderer>().material = Not_Color;

                break;

            case 4:

                Case_2.GetComponent<Renderer>().material = Not_Color;
                Case_3.GetComponent<Renderer>().material = Not_Color;
                Case_4.GetComponent<Renderer>().material = Not_Color;
                Case_5.GetComponent<Renderer>().material = Not_Color;

                break;

            case 5:

                Case_1.GetComponent<Renderer>().material = Not_Color;
                Case_2.GetComponent<Renderer>().material = Not_Color;
                Case_3.GetComponent<Renderer>().material = Not_Color;
                Case_4.GetComponent<Renderer>().material = Not_Color;
                Case_5.GetComponent<Renderer>().material = Not_Color;

                break;
        }
	}
}
