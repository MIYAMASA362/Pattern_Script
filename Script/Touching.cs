using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Touching : MonoBehaviour {

    public LayerMask mask;

    public GameObject RayObject;

    public static List<int> Int_List = new List<int>();

    private List<int> Touch_List = new List<int>();

    private Ray ray;

    public static int HIT_NUMBER;

    public static string HIT_OBJECT_NAME;

    public static bool MOVE_LIST;

    void Start () {

        HIT_NUMBER = 0;

        Touch_List.Clear();

        MOVE_LIST = false;

    }

    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            //Rayの作成
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        }

        if (Input.GetMouseButtonUp(0))
        {
            //rayを無効な位置に飛ばす
            //本当は消したい
            ray = Camera.main.ScreenPointToRay(Vector3.zero);

            
        }

        Debug.DrawRay(ray.origin, ray.direction, Color.red, 3.0f);

        //Rayが当たった時の処理
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, mask))
        {
            //Rayが当たるオブジェクトがあった場合はそのオブジェクト名をログに表示
            //Debug.Log(hit.collider.gameObject.name);

            HIT_OBJECT_NAME = hit.collider.gameObject.name;
        }

        if (HIT_NUMBER != 0 && MOVE_LIST ==false)
        {
            Touch_List.Add(HIT_NUMBER);

            MOVE_LIST = true;
        }

        for (int i = 0; i < Touch_List.Count; i++)
        {
            Debug.Log("リスト要素"+Touch_List[i]);
        }

        //Debug.Log("リスト総数"+Touch_List.Count);
    }
}
