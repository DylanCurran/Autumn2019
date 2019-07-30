using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosTextUI : MonoBehaviour
{
    public Text _posText;

    // Update is called once per frame
    void Update()
    {
        _posText.text = "Pos: 1/2";
    }
}
