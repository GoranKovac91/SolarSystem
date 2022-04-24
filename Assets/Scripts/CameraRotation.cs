using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraRotation : MonoBehaviour
{
    [SerializeField] private Vector3 _previousPosition;
    [SerializeField] private Camera _mainCamera;
    [SerializeField] private Vector3 offset;
    private void Awake()
    {
        _mainCamera = GetComponent<Camera>();
    }
    private void Update()
    {
        
       
        if (Input.GetMouseButtonDown(0))
        {
            _previousPosition = _mainCamera.ScreenToViewportPoint(Input.mousePosition);         
        }
      
            if ( Input.GetMouseButton(0))
            {
                
                Vector3 direction = _previousPosition - _mainCamera.ScreenToViewportPoint(Input.mousePosition);
                _mainCamera.transform.Rotate(new Vector3(1, 0, 0), direction.y * 180);
                _mainCamera.transform.Rotate(new Vector3(0, 1, 0), -direction.x * 180, Space.World);
                _previousPosition = _mainCamera.ScreenToViewportPoint(Input.mousePosition);
            }
          
        
    
    }
}
