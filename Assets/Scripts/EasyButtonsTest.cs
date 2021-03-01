using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyButtons;

public class EasyButtonsTest : MonoBehaviour
{
    [Button]
    public void SayHello()
    {
        Debug.Log("Hello World!");
    }

    [Button(Mode = ButtonMode.EnabledInPlayMode)]
    public void WorkInPlayMode()
    {
        Debug.Log("I just work when play mode is active");
    }

    [Button(Mode = ButtonMode.DisabledInPlayMode)]
    public void WorkInEditMode()
    {
        Debug.Log("I just work when play mode is inactive");
    }

    [Button]
    public void ButtonWithParameters(string message, int number)
    {
        Debug.Log($"Your message #{number}: '{message}'");
    }

    [Button(Mode = ButtonMode.EnabledInPlayMode)]
    public void AddNumbersInPlaymode(int number1, int number2)
    {
        Debug.Log($"The sum of the typed numbers is {number1 + number2}");
    }

    [Button(Mode = ButtonMode.AlwaysEnabled, Spacing = ButtonSpacing.After)]
    public void SeparateButtonAfter()
    {
        Debug.Log("Í'm separated from other buttons");
    }

    [Button(Spacing = ButtonSpacing.Before)]
    public void SeparateButtonBefore()
    {
        Debug.Log("I'm significantly separated from other buttons");
    }
}
