using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //変数の宣言
        int score;
        //変数の代入
        score = 150;
        //コンソールに変数の中身を表示
        Debug.Log(score);


        //変数を初期化する
        int a = 3;
        int b = 4;
        //変数aと変数bの合計値を変数cに代入する
        int c = a + b;
        //変数cを表示する
        Debug.Log(c);


        //moneyを100で初期化する
        int money = 100;

        if (money <= 50)
        {
            //moneyの値が50以下の場合
            Debug.Log("武器を売る");
        }
        else if(money >= 200)
        {
            //moneyが200以上の場合
            Debug.Log("武器を買う");
        }
        else
        {
            //moneyが100未満だった場合
            Debug.Log("ポーションを買う");
        }

        //numを1で初期化する
        int num = 1;
        //valに代入する値を条件によって変える(三項演算子)
        int val = (num == 1) ? -100 : 100;
        //valの値を表示する
        Debug.Log(val);

        //5回処理を繰り返す
        for (int i = 0; i < 5 ; i++)
        {
            Debug.Log(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
