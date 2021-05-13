using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] // public  사용 가능 
    GameObject missilePrefabs; //미사일 프리팹
    
    public Transform firePosition; //미사일 시작위치


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
      if(Input.GetButtonDown("Fire1")) //fire1 버튼 누르기
        {
            Instantiate(missilePrefabs, firePosition.position, Quaternion.identity); //프리팹, 발사위치, 총알방향
        }
    }


}

    
