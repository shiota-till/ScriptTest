using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test7 : MonoBehaviour
{
    //第一引数と第二引数の値を足した値を返す関数
    int Add(int a, int b, int c)
    {
        //第一引数と第二引数の値を足して、変数cに代入する
        int k = a + b + c;
        //変数cを呼び出し元の関数へ返す
        return k;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Add関数に「3」と「6」の引数を渡し、返り値をnumに代入する
        int num = Add(3, 6, 9);
        //numを表示する
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
