using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public UnityEngine.UI.Text SL;
    public GameObject FC;

    void Update () {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        SL.text = count.ToString();

        if( count == 0 ){
            FC.SetActive(true);
        }
    }
}
