using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int money = 200;
        int Wepon = 0;


        if (money == 200 && Wepon == 0)
        {
            Debug.Log("•Ší‚ğ”ƒ‚¤");
        }
        else if (money < 200 && Wepon == 2) 
        {
            Debug.Log("•Ší‚ğ”„‚é");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
