using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //sum��0�o����������
        int sum = 0;
        //10�񏈗����J��Ԃ�
        for(int i = 1; i < 10; i++)
        {
            //i�̒l��sum�ɑ���
            sum += i;
        }
        //sum�̒l��\������
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
