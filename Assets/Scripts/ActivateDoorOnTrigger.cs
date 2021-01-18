using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDoorOnTrigger : MonoBehaviour
{
    // Start is called before the first frame update
   // public Material matcol ; 
   // public BoxCollider coll ;
      public GameObject gob ;
    void Start()
    {
             
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnTriggerEnter(Collider col){
             
             Destroy(gob);
             
             
             //Color color =  matcol.color ;
             //color.a = 0f ;
             //coll.isTrigger = true ;
             
             //door.GetComponent<MeshCollider>().convex.Equals(true);
             //door.GetComponent<MeshCollider>().isTrigger.Equals(true);
             
           
           

    } 
}
