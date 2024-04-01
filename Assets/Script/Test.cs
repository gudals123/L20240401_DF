using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // ¹è¿­
    //ArrayList arrayList = new ArrayList();  

    //List<string> list = new List<string>(); 
    public List<GameObject> enemys = new List<GameObject>(); 



    void Start()
    {

        for(int i =0; i < enemys.Count; i++)
        {
            Debug.Log(enemys[i].name);

        }





    }



    void Update()
    {
        
    }
}
