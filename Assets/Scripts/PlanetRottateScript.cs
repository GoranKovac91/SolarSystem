using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PlanetRottateScript : MonoBehaviour
{
    public List<GameObject> _target;
    public Vector3 _axis;
    public float speed;
 

    private void Update()
    {

        foreach (GameObject tar in _target) 
        {
            
            transform.RotateAround(tar.transform.position, _axis, speed*Time.deltaTime);
          
        }
        
    }
    
}
