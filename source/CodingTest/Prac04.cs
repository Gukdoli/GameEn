using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prac04 : MonoBehaviour
{
    public int jumsu = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (jumsu >= 80)
        {
            Debug.Log("우수");
        }
        else if (jumsu >= 60)
        {
            Debug.Log("보통");
        }
        else
        {
            Debug.Log("미흡");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
