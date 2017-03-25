using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pattern_List : MonoBehaviour {

    //パターン
    public static List<List<int>> FIRST_PATTERN_LIST = new List<List<int>>();

    //パターンのテキスト
    public static List<List<string>> FIRST_PATTERN_LIST_TEXT = new List<List<string>>();

    //スキル
    public static List<List<int>> SKILL_LIST = new List<List<int>>();

    //スキルの情報
    public static List<List<int>> SKILL_INFO = new List<List<int>>();

    //スキルのテキスト
    public static List<List<string>> SKILL_TEXT = new List<List<string>>();

    //効果テキスト
    public static List<List<string>> SKILL_EFFECT_TEXT = new List<List<string>>();

    void Start () {

        //パターン (パターン型,組み合わせ)                                要素数
        FIRST_PATTERN_LIST.Insert(0, new List<int>() { 1, 2, 3, 6, 9 });    //5
        FIRST_PATTERN_LIST.Insert(1, new List<int>() { 3, 2, 1, 4, 7 });    //5
        FIRST_PATTERN_LIST.Insert(2, new List<int>() { 1,2,3,5,7,8,9 });    //7
        FIRST_PATTERN_LIST.Insert(3, new List<int>() { 7,4,1,2,3,6,9 });    //7
        FIRST_PATTERN_LIST.Insert(4, new List<int>() { 1,2,3});
        FIRST_PATTERN_LIST.Insert(5, new List<int>() { 4,1,2,3,6,9,8,5});
        //FIRST_PATTERN_LIST.Insert(,new List<int>(){});


        //パターンテキスト
        FIRST_PATTERN_LIST_TEXT.Insert(0, new List<string>() {"緑"});
        //FIRST_PATTERN_LIST_TEXT.Insert(, new List<string>() {});


        //スキル　(スキル型,パターン型組み合わせ)  最大要素数は5なので注意                                                           
        SKILL_LIST.Insert(0, new List<int>() {0,2,1});                      //3
        SKILL_LIST.Insert(1, new List<int>() {1,3,0,0,1 });                 //5
        SKILL_LIST.Insert(2, new List<int>() {4});
        SKILL_LIST.Insert(3, new List<int>() {5});
        //SKILL_LIST.Insert(, new List<int>() { });


        //スキル情報（スキル型,List       < 魔力,攻撃力,効果 >）
        SKILL_INFO.Insert(0, new List<int>() {5,    5,  0});
        SKILL_INFO.Insert(1, new List<int>() {15,   20, 0});
        SKILL_INFO.Insert(2, new List<int>() {1,    1,  0});
        SKILL_INFO.Insert(3, new List<int>() {10,   10, 0});
        //SKILL_INFO.Insert(,new List<int>(){});


        //スキルテキスト
        SKILL_TEXT.Insert(0, new List<string>() {"攻撃0型"});
        SKILL_TEXT.Insert(1, new List<string>() {"攻撃1型"});
        SKILL_TEXT.Insert(2, new List<string>() {"攻撃2型"});
        SKILL_TEXT.Insert(3, new List<string>() {"攻撃3型"});
        //SKILL_TEXT.Insert(,new List<string>(){});


        //効果テキスト
        //SKILL_EFFECT_TEXT.Insert(, new List<string>() { });
    }

}
