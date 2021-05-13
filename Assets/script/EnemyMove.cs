using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;
    Vector3 dir;
    public GameObject effect;
    public SoundManager soundManager;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        soundManager = FindObjectOfType<SoundManager>();

        //랜덤함수를 사용 0-9안에 int값
        int ranValue = Random.Range(0, 10);

        //30퍼센트 플레이어쪽 이동
        if (ranValue < 3)
        {
            //a플레이어 찾기
            GameObject player = GameObject.Find("Player");

            if (player != null)
            {
                //b방향구하기:플레이어방향(player포지션-enemy포지션):방향벡터
                dir = player.transform.position - transform.position;
            }


            //방향크기벡터 1로 만들기
            dir.Normalize();
        }
        else
        {
            //나머지 아래로
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(dir * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {


        Instantiate(effect, transform.position, Quaternion.identity);


        if (collision.gameObject.layer == 7 || collision.gameObject.layer == 8)
        {
            soundManager.Boom();
        }

        
        //GameObject go = GameObject.Find("ScoreManager");
        //ScoreManager sm = go.GetComponent<ScoreManager>();

        //int temp = sm.GetScore();
        //sm.SetScore(temp++);


        //상대방(player) 겜오 파괴
        Destroy(collision.gameObject);

        //자기자신 겜오 파괴
        Destroy(gameObject);
    }
}