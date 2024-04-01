using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1.45f;
    public GameObject hit;
    
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    // ȭ�� �ۿ� ���� �Ⱥ��� ��� ȣ�� �Ǵ� �Լ�
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


    //Ʈ���� �浹
    //�ݸ��� �浹
    // enter 1�� ���ö� (ex.�Ѿ�)
    // stay ��� �浹�Ҷ� (ex.������)
    // exit �浹�� ������ �������� 1��

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�̻��ϰ� ���� �ε�����.
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Instantiate(hit, transform.position, Quaternion.identity);
            Destroy(hit);
            //�� �����
            Destroy(collision.gameObject);

            //�� �ڽ� �����
            Destroy(gameObject);
            
        }

    }




}
