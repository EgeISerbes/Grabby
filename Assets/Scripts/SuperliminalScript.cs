using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperliminalScript : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Components")]
    public Transform target ;

    [Header("Parameters")]
    public LayerMask targetMask ;
    public LayerMask ignoreTargetMask ;
    public float offsetFactor;

    float originalDistance;
    float originalScale;
    Vector3 targetScale;


    void Start()
    {
        Cursor.visible = false ;
        Cursor.lockState = CursorLockMode.Locked ;
    }

    // Update is called once per frame
    void Update()
    {
        HandleObject();
        ResizeObject();
    }

    void HandleObject(){

        if (Input.GetButtonDown("Fire1"))
        {
            if (target== null)
            {
                RaycastHit rcHit ;
                if (Physics.Raycast(transform.position,transform.forward,out rcHit,Mathf.Infinity,targetMask)){

                    target = rcHit.transform ;
                    target.GetComponent<Rigidbody>().isKinematic = true ;
                    originalDistance = Vector3.Distance(transform.position,target.position);
                    originalScale = target.localScale.x ;
                    targetScale = target.localScale ;

                }

            }
            else {
                target.GetComponent<Rigidbody>().isKinematic = false; 
                target =null ;
            }
        }
    }


    void ResizeObject(){

        if (target == null)
        {
            return ;
        }

        RaycastHit hit ;
        if(Physics.Raycast(transform.position,transform.forward,out hit,3000,ignoreTargetMask))
        {
            target.position = hit.point - transform.forward*offsetFactor* target.localScale.x ;
            float currentDistance = Vector3.Distance(transform.position,target.position);
            float s = currentDistance/originalDistance ;
            targetScale.x = targetScale.y = targetScale.z = s ;
            target.localScale = targetScale*originalScale;
        }
    }
}
