using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;
public class LoadNextLevel : MonoBehaviour
{
    public Collider coll ; 
    void OnTriggerEnter(Collider col) {
        if (coll.name == col.name)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        else
        return ;
    }

    // Update is called once per frame
    
}
