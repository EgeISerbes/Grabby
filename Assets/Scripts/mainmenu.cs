using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{   
    public BoxCollider coll ; 
    public void PlayClicked(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

    }

    public void QuitClicked(){
        Application.Quit();
    }
   
}
