using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    // ��ũ���� �Ǵ� ��׶���
    public float scrollSpeed = 0.3f;
    private Material myMaterial;

    void Start()
    {
        //���͸��� ��������

        myMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        //������ �ӷ�Ƽ�󿡼� ��������
        Vector2 newOffset = myMaterial.mainTextureOffset;

        //���Ӱ� offset �ٲ��ֱ�
        //y �κ� ���� �ӵ��� ������ �����ؼ� �����ݴϴ�.
        newOffset.Set(0,newOffset.y + (scrollSpeed * Time.deltaTime));
        //���͸��� ������ ���� �־��ش�.
        myMaterial.mainTextureOffset = newOffset;   

    }
}
