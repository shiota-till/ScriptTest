using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 0, 1, 10, 11, 100, 101, 110, 111, 1000, 1001, 1010, 1011, 1100, 1110, 1111 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int k = array.Length - 1; k >= 0; k--)
        {
            Debug.Log(array[k]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
