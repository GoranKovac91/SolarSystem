using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BasicInfoScript : MonoBehaviour
{
    [SerializeField] public List <TextMeshProUGUI> _basicInformation;
    private static BasicInfoScript _instance;
    public static BasicInfoScript Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("Instance is null");
            }
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
    }
    private void OnEnable()
    {
        for (int i = 0; i < _basicInformation.Count; i++)
        {
            _basicInformation[i].enabled = false;
        }
        _basicInformation[0].enabled = true;
    }

}
