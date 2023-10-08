using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using TMPro;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public bool canBePressed;
    [SerializeField] private KeyCode _keyToPress;

    private void Start()
    {
        canBePressed= false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(_keyToPress))
        {
            if (canBePressed)
            {
                Destroy(gameObject);
                GameManager.Instance.score++;
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
        TogglePressing(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        TogglePressing(false);
    }

    public void TogglePressing(bool toggle)
    {
        canBePressed = toggle;
    }
}
