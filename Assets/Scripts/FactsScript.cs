using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FactsScript : MonoBehaviour
{
    [SerializeField] public List<TextMeshProUGUI> facts;
    private static FactsScript _instance;
    public static FactsScript Instance
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
        for (int i = 0; i < facts.Count; i++)
        {
            facts[i].enabled = false;
        }
        facts[0].enabled = true;

    }
}
