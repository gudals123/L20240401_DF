using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 스피드
    public float moveSpeed = 3f;
    

    void Start()
    {
            
    }

    void Update()
    {
        //x쪽 값 설정 vecter 방향 * 시간 * 스피드
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //distanceX = Math.Clamp(distanceX,-1,1);

        //x쪽 이동 설정
        transform.Translate(distanceX, 0, 0);



    }
}
