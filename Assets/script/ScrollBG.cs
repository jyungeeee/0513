using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBG : MonoBehaviour
{
    public Material material;

    float speed = 0.5f; //�����̴� �ӵ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //��� ���� �����̱�
    {
        Vector2 dir = Vector2.up;
        material.mainTextureOffset += dir * speed * Time.deltaTime;
    }
}
