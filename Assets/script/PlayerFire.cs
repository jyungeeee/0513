using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] // public  ��� ���� 
    GameObject missilePrefabs; //�̻��� ������
    
    public Transform firePosition; //�̻��� ������ġ


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
      if(Input.GetButtonDown("Fire1")) //fire1 ��ư ������
        {
            Instantiate(missilePrefabs, firePosition.position, Quaternion.identity); //������, �߻���ġ, �Ѿ˹���
        }
    }


}

    
