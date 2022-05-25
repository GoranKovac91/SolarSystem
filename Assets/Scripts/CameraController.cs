using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
       
    [SerializeField] private Camera _camera;
    [SerializeField] private float _panSpeed=100.0f;
    [SerializeField] private float _panBorderThickness = 20.0f;
    
  
    private void Awake()
    {
        _camera = GetComponent<Camera>();
    }
  
    void Update()
    {
        
        
        if (Input.GetKey("w") )
        {
            
            _camera.transform.Translate(Vector3.forward * _panSpeed * Time.deltaTime);
        }
        if (Input.GetKey("s") )
        {
            _camera.transform.Translate(-Vector3.forward * _panSpeed * Time.deltaTime);
        }
        if (Input.GetKey("d") )
        {
            _camera.transform.Translate(-Vector3.left * _panSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            _camera.transform.Translate(Vector3.left * _panSpeed * Time.deltaTime);

        }
       
        Zoom();
           
     
    }
 

    public void Zoom()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            _camera.fieldOfView++;
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            _camera.fieldOfView--;
        }

    }
   
}

