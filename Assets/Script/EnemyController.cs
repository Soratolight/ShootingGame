using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    float fallSpeed;
    //float rotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        this.fallSpeed = 0.01f + 0.1f * Random.value;
        //this.rotSpeed = 5f + 3f * Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);

        //指定した座標を超えると削除
        if(transform.position.y < -5.5f ) {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            Destroy(gameObject);
            SceneManager.LoadScene("TitleScene");
        }
    }
}
