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

        //�����Լ��� ��� 0-9�ȿ� int��
        int ranValue = Random.Range(0, 10);

        //30�ۼ�Ʈ �÷��̾��� �̵�
        if (ranValue < 3)
        {
            //a�÷��̾� ã��
            GameObject player = GameObject.Find("Player");

            if (player != null)
            {
                //b���ⱸ�ϱ�:�÷��̾����(player������-enemy������):���⺤��
                dir = player.transform.position - transform.position;
            }


            //����ũ�⺤�� 1�� �����
            dir.Normalize();
        }
        else
        {
            //������ �Ʒ���
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


        //����(player) �׿� �ı�
        Destroy(collision.gameObject);

        //�ڱ��ڽ� �׿� �ı�
        Destroy(gameObject);
    }
}