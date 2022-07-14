using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointTextReference : MonoBehaviour
{
    public TextMeshProUGUI Text;

    private void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }
}
