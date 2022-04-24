using System.Collections;
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
    [SerializeField] protected Button _nextButton;
    [SerializeField] protected int _activeInfoText = 0;
    private void Awake()
    {
        _dropdown = GetComponent<Dropdown>();
   
    }
    private void Start()
    {
        for (int i = 0; i < infoTexts.Count; i++)
        {
           infoTexts[i].enabled = false ;
        }
      
        infoTexts[0].enabled = true;
    }

    public void ChangeInfo(Dropdown dropdown)
    {
        switch (dropdown.value)
        {
            case 0:
                DropdownTexts.ElementAt(0).enabled = true;
                break;
            case 1:
                DropdownTexts.ElementAt(1).enabled = true;
                DropdownTexts.ElementAt(0).enabled = false;
                break;
            case 2:
                DropdownTexts.ElementAt(1).enabled = false;
                DropdownTexts.ElementAt(0).enabled = false;
                DropdownTexts.ElementAt(3).enabled = true;
                break;
        }
    }
    public void OnClick()
    {
        infoTexts[_activeInfoText].enabled = false;
        _activeInfoText = (_activeInfoText + 1) % infoTexts.Count;
        infoTexts[_activeInfoText].enabled = true;
       
    }



}
