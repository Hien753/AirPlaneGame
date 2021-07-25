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
    /// 衝突した時
    /// </summary>
    /// <param name="collision"></param>
    void OnTriggerEnter(UnityEngine.Collider other)
    {
        // 衝突した相手にPlayerタグが付いているとき
        if (other.CompareTag("Player")) ;
        {
            //スコア加算
            scoreObject2.GetComponent<CountText>().AddScore2();
            // 0.2秒後に消える
            Destroy(gameObject);
        }
    }
}
