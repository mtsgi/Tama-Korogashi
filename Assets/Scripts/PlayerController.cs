using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 10;

    void FixedUpdate(){

        // 入力をxとzに代入
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rb = GetComponent<Rigidbody>();

        // rigidbodyのx軸（横）とz軸（奥）に力を加える
        rb.AddForce(x*speed, 0, z*speed);
    }
}