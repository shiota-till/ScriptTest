using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test7 : MonoBehaviour
{
    //�������Ƒ������̒l�𑫂����l��Ԃ��֐�
    int Add(int a, int b, int c)
    {
        //�������Ƒ������̒l�𑫂��āA�ϐ�c�ɑ������
        int k = a + b + c;
        //�ϐ�c���Ăяo�����̊֐��֕Ԃ�
        return k;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Add�֐��Ɂu3�v�Ɓu6�v�̈�����n���A�Ԃ�l��num�ɑ������
        int num = Add(3, 6, 9);
        //num��\������
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
