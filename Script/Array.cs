using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Array : MonoBehaviour {

    private List<int> Int_List = new List<int>();

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Int_List.Add(1);
            Int_List.Add(2);
            Int_List.Add(3);
        }

        for (int i=0; i< Int_List.Count; i++) {

            //Debug.Log("要素番号"+i+":"+Int_List[i]);

            //Debug.Log(Int_Array[i]);
        }

        //Debug.Log("総要素数"+Int_List.Count);

        
	}
}
