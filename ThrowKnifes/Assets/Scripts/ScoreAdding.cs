using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreAdding : MonoBehaviour
{
    public float score = 0;
    public TextMeshProUGUI Text;

    public void AddPoints()
    {
        score++;
        Text.text = score.ToString();
    }
}
