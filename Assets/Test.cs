using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�ϐ��̐錾
        int score;
        //�ϐ��̑��
        score = 150;
        //�R���\�[���ɕϐ��̒��g��\��
        Debug.Log(score);


        //�ϐ�������������
        int a = 3;
        int b = 4;
        //�ϐ�a�ƕϐ�b�̍��v�l��ϐ�c�ɑ������
        int c = a + b;
        //�ϐ�c��\������
        Debug.Log(c);


        //money��100�ŏ���������
        int money = 100;

        if (money <= 50)
        {
            //money�̒l��50�ȉ��̏ꍇ
            Debug.Log("����𔄂�");
        }
        else if(money >= 200)
        {
            //money��200�ȏ�̏ꍇ
            Debug.Log("����𔃂�");
        }
        else
        {
            //money��100�����������ꍇ
            Debug.Log("�|�[�V�����𔃂�");
        }

        //num��1�ŏ���������
        int num = 1;
        //val�ɑ������l�������ɂ���ĕς���(�O�����Z�q)
        int val = (num == 1) ? -100 : 100;
        //val�̒l��\������
        Debug.Log(val);

        //5�񏈗����J��Ԃ�
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
