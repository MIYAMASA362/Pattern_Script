using UnityEngine;
using System.Collections;

public class TP : MonoBehaviour {

    public int POINT_NUMBER;

    public static int PUBLIC_POINT_NUMBER;

    private bool THIS_MOVED;

	// Use this for initialization
	void Start () {

        THIS_MOVED = false;

        PUBLIC_POINT_NUMBER = POINT_NUMBER;
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Touching.HIT_OBJECT_NAME == this.name && THIS_MOVED == false)
        {
            Touching.HIT_NUMBER = POINT_NUMBER;

            THIS_MOVED = true;

            Touching.MOVE_LIST = false;
        }
	
	}
}
