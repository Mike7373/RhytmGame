using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int _score;
    private TMP_Text _tmpText;
    private void Awake()
    {
        GameManager.Instance.scoreText = this;
    }
}
