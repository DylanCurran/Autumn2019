using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapTextUI : MonoBehaviour
{
    public Text _lapText;

    // Update is called once per frame
    void Update()
    {
        _lapText.text = "Lap 1/3";
    }
}
