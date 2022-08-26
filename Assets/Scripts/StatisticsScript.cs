using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatisticsScript : MonoBehaviour
{
    [SerializeField] public  List<TextMeshProUGUI> statistics;
    private static StatisticsScript _instance;
    public static StatisticsScript Instance
    {
        get
        {
            if (_instance==null)
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
        for (int i = 0; i < statistics.Count; i++)
        {
            statistics[i].enabled = false;
        }
        statistics[0].enabled = true;

    }
}
