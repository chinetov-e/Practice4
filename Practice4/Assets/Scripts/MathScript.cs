using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Unity.VisualScripting;
using System;

public class MathScript : MonoBehaviour
{
    [SerializeField] private InputField firstDigitCal;
    [SerializeField] private InputField secondDigitCal;
    [SerializeField] private InputField firstDigitCom;
    [SerializeField] private InputField secondDigitCom;
    [SerializeField] private Text calculatorResult;
    [SerializeField] private Text compareResult;
    [SerializeField] private GameObject firstScreen;
    [SerializeField] private GameObject secondScreen;
    private GameObject currentScreen;

    private void Start()
    {
        firstScreen.SetActive(true);
        currentScreen = firstScreen;

    }

    public void ChangeState(GameObject state)
    {
        if(currentScreen != null)
        {
            currentScreen.SetActive(false);
            state.SetActive(true);
            currentScreen = state;
        }
    }

    public void Sum ()
    {
        calculatorResult.text = (Convert.ToDouble(firstDigitCal.text) + Convert.ToDouble(secondDigitCal.text)).ToString();
    }

    public void Subtraction()
    {
        calculatorResult.text = (Convert.ToDouble(firstDigitCal.text) - Convert.ToDouble(secondDigitCal.text)).ToString();
    }

    public void Division()
    { 
        calculatorResult.text = (Convert.ToDouble(firstDigitCal.text) / Convert.ToDouble(secondDigitCal.text)).ToString();
    }

    public void Multiplication()
    {
        calculatorResult.text = (Convert.ToDouble(firstDigitCal.text) * Convert.ToDouble(secondDigitCal.text)).ToString();
    }

    public void Compare()
    {
        if (Convert.ToDouble(firstDigitCom.text) == Convert.ToDouble(secondDigitCom.text))
        {
            compareResult.text = "Равны";
        }
        else if(Convert.ToDouble(firstDigitCom.text) <= Convert.ToDouble(secondDigitCom.text))
        {
            compareResult.text = secondDigitCom.text;
        }
        else if (Convert.ToDouble(firstDigitCom.text) >= Convert.ToDouble(secondDigitCom.text))
        {
              compareResult.text = firstDigitCom.text;
        }
    }
}
