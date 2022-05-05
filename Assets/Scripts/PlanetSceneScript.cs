using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

public class PlanetSceneScript : MonoBehaviour
{
    [SerializeField] protected Dropdown _dropdown;
    [SerializeField] protected List<Text> DropdownTexts;
    [SerializeField] protected List<Text> infoTexts;
    [SerializeField] protected  List<Text> _statisticsText;
    [SerializeField] protected int _activeInfoText = 0;
    [SerializeField] private GameObject _infoObject;
    [SerializeField] private GameObject _statisticsObject;

    private void Awake()
    {
        _dropdown = GetComponent<Dropdown>();

    }
    private void Start()
    {
        _infoObject.SetActive(true);
        _statisticsObject.SetActive(false);
    }
 

    public void ChangeInfo(Dropdown dropdown)
    {
        switch (dropdown.value)
        {
            case 0:
                _infoObject.SetActive(true);
                _statisticsObject.SetActive(false);

                break;
            case 1:
                _statisticsObject.SetActive(true);
                _infoObject.SetActive(false);

                break;
            case 2:
                
                break;
             
        }
    }
    public void OnClickNext()
    {
      
        SetList()[_activeInfoText].enabled = false;
        _activeInfoText = (_activeInfoText + 1) % SetList().Count;
        SetList()[_activeInfoText].enabled = true;
       
    }
    public void OnClickPrevious()
    {
        if (_activeInfoText <= 0)
        {
            return;
        }
        SetList()[_activeInfoText].enabled = false;
        _activeInfoText = (_activeInfoText - 1) % SetList().Count;
        SetList()[_activeInfoText].enabled = true;

    }

    public List<Text> SetList()
    {
        if (_infoObject.activeSelf==true)
        {
            return BasicInfoScript.Instance._basicInformation;
                
        }
        else if (_statisticsObject.activeSelf==true)
        {
            return StatisticsScript.Instance.statistics;
        }
        else
        {
            return null;
        }
                
    }


  




}
