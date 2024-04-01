using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;   //미사일 프리팹 가져올 변수
    
    public AudioSource audioSource;


    void Start()
    {
        InvokeRepeating("Shoot", 0.5f, 0.5f);
    }


    void Shoot()
    {
        audioSource.Play();
        //미사일 프리팹, 런쳐 포지션, 방향값 없음
        Instantiate(bullet,transform.position,Quaternion.identity);


    }


    void Update()
    {
        
    }
}
