using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public AudioSource audioSource;
    

    [SerializeField]
    public float speed = 5; //�̻��� �ӵ�

    // Start is called before the first frame update
    void Start()
    {

    }
 

    // Update is called once per frame
    void Update()
    {

        // ���� �̵�
        transform.Translate(Vector3.up * 5 * Time.deltaTime);


    }
}
