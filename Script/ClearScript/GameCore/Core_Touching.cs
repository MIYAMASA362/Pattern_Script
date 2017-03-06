using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Core_Touching : MonoBehaviour {

    //Rayの当たり判定を行うレイヤー(判定レイヤー)
    public LayerMask mask;

//プライベート

    //タッチポジションの値を集めるリスト
    public static List<string> Touch_List = new List<string>();

    //レイ
    private Ray Main_Ray;


//グローバル

    //当たり判定を行ったポジションの値
    public static bool HIT_BOOL;

    //当たり判定を行う際にオブジェクトを参照する為
    public static string HIT_OBJECT_NAME;

    //リストに無限に値が入らない様に一回動作の抑制真偽値
    public static bool LIST_OVER;

    //Touch_Positionの初期化
    public static bool RESET_TP;

    public static bool MOVE_UP;

//初期化
	void Start () {

        //Touch_Positionの初期化
        RESET_TP = false;

        //条件文に作用させない値に変更
        HIT_BOOL = false;

        //リスト初期化
        Touch_List.Clear();

        //抑制を解除した状態
        LIST_OVER = false;
	
	}
	
	void Update () {

//動作1
        //左クリックされている時Rayを移動させる
        if (Input.GetMouseButton(0))
        {
            //Rayのマウス位置への移動
            Main_Ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //リセットが働かないように初期化
            RESET_TP = false;

            MOVE_UP = false;
        }

//

//動作2 ===> Touch_Position動作1(HIT_OBJECT_NAME)
        
        //Rayが当たった時の処理
        RaycastHit hit;

        //Maskに対応したオブジェクトとに判定を行う
        if (Physics.Raycast(Main_Ray, out hit, Mathf.Infinity, mask))
        {
            //参照する為に渡し
            HIT_OBJECT_NAME = hit.collider.gameObject.name;
        }

// 

//動作3<=== Touch_Position動作1(LIST_OVER = false; HIT_NUMBER)

        //0以外の時　抑制真偽値が動いていない時
        if (HIT_BOOL == true && LIST_OVER == false)
        {
            //オブジェクトの値を入れる
            Touch_List.Add(HIT_OBJECT_NAME);

            LIST_OVER = true;

            HIT_BOOL = false;
        }

//

//動作4 

        //左クリックが解除された際にRayの位置を無効位置に
        if (Input.GetMouseButtonUp(0))
        {
            //本当はRayを消したい
            Main_Ray = Camera.main.ScreenPointToRay(Vector3.zero);

            //リストを消去
            Touch_List.Clear();

            //リセットを有効
            //RESET_TP = true;

            MOVE_UP = true;

            //HIT_NUMBERを初期化
            HIT_BOOL = false;

            //HIT_OBJECT_NUMBERを初期化
            HIT_OBJECT_NAME = null;
        }

// ===>Touch_Position動作2(RESET_TP = true)


//任意動作・デバック動作

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            //リストを消去
            Touch_List.Clear();
            Debug.Log("Spaceキー入力");
        }*/

        /*
        //要素の確認
        for(int i = 0; i < Touch_List.Count; i++)
        {
            Debug.Log(Touch_List[i]);
        }

        
        //総要素数の確認
        //Debug.Log(Touch_List.Count);

        //リセットの確認
        //Debug.Log("RE:"+RESET_TP);

        //HIT_NUMBERの確認
        //Debug.Log("HIT_N:"+HIT_NUMBER);

        //HIT_OBJECT_NAMEの確認
        //Debug.Log("HIT_ON:" + HIT_OBJECT_NAME);
	    */
    }
}
