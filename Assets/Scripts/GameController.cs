using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public UnityEngine.UI.Text SL;
    public GameObject FC;

    public int remain = 999;

    private void Start(){
        remain = GameObject.FindGameObjectsWithTag("Item").Length;
    }

    void Update () {
        SL.text = remain.ToString();

        if( remain == 0 ){
            if( SceneManager.GetActiveScene().name == "DefaultScene"){
                SceneManager.LoadScene("HardScene");
            }
            else if (SceneManager.GetActiveScene().name == "HardScene"){
                SceneManager.LoadScene("ExtraScene");
            }
            else FC.SetActive(true);
        }
    }
}