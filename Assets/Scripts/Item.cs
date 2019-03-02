using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour{
    public GameController GC;
    public bool flag = false;

    void OnTriggerEnter( Collider hit ){
        if( hit.CompareTag("Player") ){
            GC.remain--;
            this.flag = true;
        }
    }
    private void Update(){
        this.gameObject.transform.Rotate(5,0,0);
        if( this.flag ){
            this.gameObject.transform.position += new Vector3(0,1,0);
        }
    }
}