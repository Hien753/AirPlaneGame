using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem : MonoBehaviour
{
    GameObject scoreObject2;

    private void Start()
    {
        scoreObject2 = GameObject.Find("GameObject");
    }

    /// <summary>
    /// �Փ˂�����
    /// </summary>
    /// <param name="collision"></param>
    void OnTriggerEnter(UnityEngine.Collider other)
    {
        // �Փ˂��������Player�^�O���t���Ă���Ƃ�
        if (other.CompareTag("Player")) ;
        {
            //�X�R�A���Z
            scoreObject2.GetComponent<CountText>().AddScore2();
            // 0.2�b��ɏ�����
            Destroy(gameObject);
        }
    }
}
