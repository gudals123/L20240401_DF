using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;   //�̻��� ������ ������ ����
    
    public AudioSource audioSource;


    void Start()
    {
        InvokeRepeating("Shoot", 0.5f, 0.5f);
    }


    void Shoot()
    {
        audioSource.Play();
        //�̻��� ������, ���� ������, ���Ⱚ ����
        Instantiate(bullet,transform.position,Quaternion.identity);


    }


    void Update()
    {
        
    }
}
