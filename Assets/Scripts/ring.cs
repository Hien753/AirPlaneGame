using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ring : MonoBehaviour
{
	GameObject scoreObject;

    private void Start()
    {
        scoreObject = GameObject.Find("GameObject");
    }

    /// <summary>
    /// �Փ˂�����
    /// </summary>
    /// <param name="collision"></param>
    void OnTriggerEnter(UnityEngine.Collider other)
    {
        // �Փ˂��������Player�^�O���t���Ă���Ƃ�
        if (other.CompareTag("Player"));
		{
            //�X�R�A���Z
            scoreObject.GetComponent<CountText>().AddScore();
			// 0.2�b��ɏ�����
			Destroy(gameObject);
		}
	}
}
