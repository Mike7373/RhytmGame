using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using TMPro;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private bool _canBePressed;
    [SerializeField] private int _scoreValue;
    [SerializeField] private int _triggerCount;
    [SerializeField] private KeyCode _keyToPress;

    private void Start()
    {
        _canBePressed= false;
        _scoreValue= 0;
        _triggerCount= 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(_keyToPress))
        {
            if (_canBePressed)
            {
                Destroy(gameObject);
                GameManager.Instance.score+= _scoreValue;
                GameManager.Instance.scoreText.GetComponent<TMP_Text>().text = GameManager.Instance.score.ToString();
            }
        }
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
        transform.position -= new Vector3(0, (GameManager.Instance.arrowMovSpeed * Time.deltaTime), 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TogglePressing();   
        UpdateScoreValue();
        _triggerCount++;
    }

    private void TogglePressing()
    {
        if (_triggerCount == 0)
        {
            _canBePressed = true;
        }
        else if (_triggerCount == 5)
        {
            _canBePressed = false;
        }
    }

    private void UpdateScoreValue()
    {
        if (_triggerCount < 3)
        {
            _scoreValue++;
        }
        else
        {
            _scoreValue--;
        }
    }
}
