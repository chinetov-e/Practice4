using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Unity.VisualScripting;
using System;

public class MathScript : MonoBehaviour
{
    [SerializeField] private InputField firstDigit;
    [SerializeField] private InputField secondDigit;
    [SerializeField] private Text result;
    private int sum = 0;

    public void Sum ()
    {
        sum = Convert.ToInt32(firstDigit.text) + Convert.ToInt32(secondDigit.text);
        result.text = sum.ToString();
    }

    public void Subtraction()
    {
        sum = Convert.ToInt32(firstDigit.text) - Convert.ToInt32(secondDigit.text);
        result.text = sum.ToString();
    }

    public void Division()
    { 
        sum = Convert.ToInt32(firstDigit.text) / Convert.ToInt32(secondDigit.text);
        result.text = sum.ToString();
    }

    public void Multiplication()
    {
        sum = Convert.ToInt32(firstDigit.text) * Convert.ToInt32(secondDigit.text);
        result.text = sum.ToString();
    }
}
