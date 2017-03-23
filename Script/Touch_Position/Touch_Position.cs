using UnityEngine;
using System.Collections;

public class Touch_Position : MonoBehaviour {

    public Material Touch_Color;
    public Material Touched_Color;
    public Material Touch_NOT_Color;

    //リストに入れる値　判定値
    public int POINT_NUMBER;

    //無限に動くのを抑制する為の値
    private bool THIS_MOVED;

	void Start () {

        //初期化
        THIS_MOVED = false;
	}
	
	// Update is called once per frame
	void Update () {

//動作1 <=== Core_Touching動作2(HIT_OBJECT_NAME)

        if (Core_Touching.HIT_OBJECT_NAME == this.name && THIS_MOVED == false)
        {
            Core_Touching.HIT_BOOL = true;

            THIS_MOVED = true;

            GetComponent<Renderer>().material = Touched_Color;

            Core_Touching.LIST_OVER = false;
        }

// ===> Core_Touching(LIST_OVER = false; HIT_NUMBER)

//動作2 <===Core_Touching動作4(RESET_TP = true)

        //リセットが有効されたら
        if (Core_Touching.RESET_TP == true)
        {
            if (Player_Status.MP_NOTING == true)
            {
                THIS_MOVED = true;

                GetComponent<Renderer>().material = Touch_NOT_Color;
            }
            else
            {
                GetComponent<Renderer>().material = Touch_Color;

                THIS_MOVED = false;
            }
        }
//
    }
}
