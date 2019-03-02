using System.Collections;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public GameObject target;  // ターゲットへの参照
    Vector3 offset;

    void Start(){
        //自分自身とtargetとの相対距離を求める
        offset = GetComponent<Transform>().position - target.transform.position;
    }

    // Update is called once per frame
    void Update () {
        GetComponent<Transform>().position = target.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.position + offset;
    }
}