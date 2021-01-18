using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;
public class ReturnClicked : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReturnC()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
