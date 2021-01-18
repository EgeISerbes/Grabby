using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Look : MonoBehaviour
{
    // Start is called before the first frame update
    public float mSensivity = 100f;
    public Transform playerBody;

    float xRotation = 0f ;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked ;
    }

    // Update is called once per frame
    void Update()
    {
      float  mousex = Input.GetAxis("Mouse X")*Time.deltaTime*mSensivity ;
      float  mousey = Input.GetAxis("Mouse Y")*Time.deltaTime*mSensivity ;

      xRotation -= mousey;
      xRotation = Mathf.Clamp(xRotation,-90f,90f);
      transform.localRotation = Quaternion.Euler(xRotation,0f,0f);

      playerBody.Rotate(Vector3.up*mousex);

    }
}
