using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

public class Earth : MonoBehaviour
{
    [SerializeField] protected Dropdown _dropdown;
    [SerializeField] protected List <Text> DropdownTexts;
    [SerializeField] protected List<Text> infoTexts;
    [SerializeField] protected List<Text> _statisticsText;
    [SerializeField] protected Button _nextButton;
    [SerializeField] protected Button _previousButton;
    [SerializeField] protected int _activeInfoText = 0;
    [SerializeField] private GameObject _infoObject;
    [SerializeField] private GameObject _statisticsObject;
    [SerializeField] private bool isChanged = false;
    private void Awake()
    {
        _dropdown = GetComponent<Dropdown>();
        _nextButton = GetComponent<Button>();
        _previousButton = GetComponent<Button>();
        
        
    }
    private void Start()
    {
        _infoObject.SetActive(true);
        _statisticsObject.SetActive(false);

        for (int i = 0; i < SetList().Count; i++)
        {
            SetList()[i].enabled = false;
        }
        SetList()[0].enabled = true;


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
        if (_activeInfoText > SetList().Count+1)
        {
            return;
        }
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
            return infoTexts;
        }
        else if (_statisticsObject.activeSelf==true)
        {
            return _statisticsText;
        }
        else
        {
            return null;
        }
                
    }
  




}
