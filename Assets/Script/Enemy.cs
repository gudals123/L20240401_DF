using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1f;    

    void Start()
    {
        
    }

    void Update()
    {
        float distansceY = moveSpeed * Time.deltaTime;
        transform.Translate(0, -distansceY, 0);

    }

    //화면 밖으로 나가면 호출
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
