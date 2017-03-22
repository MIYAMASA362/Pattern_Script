using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRender : MonoBehaviour {

	void Update () {

        LineRenderer lineY = this.GetComponent<LineRenderer>();

        lineY.SetVertexCount(Core_Touching.Touch_List.Count);

        for (int i = 0; i < Core_Touching.Touch_List.Count; i++)
        {
            lineY.SetPosition(i,GameObject.Find(Core_Touching.Touch_List[i]).transform.position);
        }

    }

}
