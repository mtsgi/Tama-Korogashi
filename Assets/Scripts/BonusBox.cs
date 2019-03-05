using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BonusBox : MonoBehaviour {

    private void OnCollisionEnter(Collision col){
        if (col.gameObject.CompareTag("Player")){
            SceneManager.LoadScene("BonusScene");
        }
    }
}
