using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //配列を初期化する
        int[] points = { 50, 26, 45, 89, 74, 25, 41, 36, 99, 65, 72, 1002, 5468 };

        //配列の要素数の分だけ処理を繰り返す
        for(int i = 0; i < points.Length; i++)
        {
            //配列の要素が50以上の場合
            if (points[i] >= 50)

                //配列の要素を表示する
                Debug.Log(points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
