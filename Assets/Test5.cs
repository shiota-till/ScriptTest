using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�z�������������
        int[] points = { 50, 26, 45, 89, 74, 25, 41, 36, 99, 65, 72, 1002, 5468 };

        //�z��̗v�f���̕������������J��Ԃ�
        for(int i = 0; i < points.Length; i++)
        {
            //�z��̗v�f��50�ȏ�̏ꍇ
            if (points[i] >= 50)

                //�z��̗v�f��\������
                Debug.Log(points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
