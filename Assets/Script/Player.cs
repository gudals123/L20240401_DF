using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // ���ǵ�
    public float moveSpeed = 3f;
    

    void Start()
    {
            
    }

    void Update()
    {
        //x�� �� ���� vecter ���� * �ð� * ���ǵ�
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //distanceX = Math.Clamp(distanceX,-1,1);

        //x�� �̵� ����
        transform.Translate(distanceX, 0, 0);



    }
}
