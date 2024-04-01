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

    // 화면 밖에 나가 안보일 경우 호출 되는 함수
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


    //트리거 충돌
    //콜리전 충돌
    // enter 1번 들어올때 (ex.총알)
    // stay 계속 충돌할때 (ex.레이져)
    // exit 충돌이 끝날때 나가질때 1번

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //미사일과 적이 부딪혔다.
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Instantiate(hit, transform.position, Quaternion.identity);
            Destroy(hit);
            //적 지우기
            Destroy(collision.gameObject);

            //나 자신 지우기
            Destroy(gameObject);
            
        }

    }




}
