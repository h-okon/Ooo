using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class buttonsOnMouseOver : MonoBehaviour
{
    public void changeTextSizeUP()
    {
        TextMeshProUGUI txt= GetComponentInChildren<TextMeshProUGUI>();
        txt.characterSpacing = 20;
    }
    public void changeTextSizeDOWN()
    {
        TextMeshProUGUI txt = GetComponentInChildren<TextMeshProUGUI>();
        txt.characterSpacing = 1;
    }
}
