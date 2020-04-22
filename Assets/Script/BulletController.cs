using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject explosionPrefab; //エフェクトのPrefab

    void Update()
    {
        transform.Translate(0, 0.2f, 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        //衝突した時にスコア更新
        GameObject.Find("Canvas").GetComponent<UIController>().AddScore();

        //エフェクト生成
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        //衝突したときにオブジェクトを消す
        Destroy(coll.gameObject);
        Destroy(gameObject);
    }
}
