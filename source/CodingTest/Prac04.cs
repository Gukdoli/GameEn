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
            Debug.Log("���");
        }
        else if (jumsu >= 60)
        {
            Debug.Log("����");
        }
        else
        {
            Debug.Log("����");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
