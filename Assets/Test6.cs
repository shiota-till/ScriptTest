using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test6 : MonoBehaviour
{
    //�uHello�v�ɑ����Ĉ����̕������\������֐�
    void HelloName(int suji)
    {
        Debug.Log("Hello" + suji);
    }

    // Start is called before the first frame update
    void Start()
    {
        HelloName(6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
