using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFirstLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider coll ; 
    void OnTriggerEnter(Collider col) {
        if (coll.name == col.name){
        Cursor.lockState = CursorLockMode.None ;
        SceneManager.LoadScene("Main Menu");
        }
        else
        return ;
    }
}
