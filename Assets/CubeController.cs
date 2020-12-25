using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update

    //キューブの移動速度
    private float speed = -12f;

    //消滅位置
    private float deadLine = -10f;

    private float vol = 0.8f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject)
        {
            GetComponent<AudioSource>().volume = vol;
        }
    }
}
