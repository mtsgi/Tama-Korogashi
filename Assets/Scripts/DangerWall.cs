using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour{
    public GameObject FC;
    private void OnCollisionEnter(Collision col){
        if( col.gameObject.CompareTag("Player") && !FC.activeSelf ) SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );       
    }
}
