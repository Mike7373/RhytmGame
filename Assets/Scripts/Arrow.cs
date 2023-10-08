using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public bool canBePressed;
    [SerializeField] private KeyCode _keyToPress;
    private float _movSpeed;

    private void Start()
    {
        canBePressed= false;
        _movSpeed = GameManager.Instance.arrowSpeed;
    }

    private void Update()
    {
        if (Input.GetKeyDown(_keyToPress))
        {
            if (canBePressed)
            {
                Destroy(gameObject);
            }
        }
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
        transform.position = transform.position + new Vector3(0, -(_movSpeed * Time.deltaTime), 0);
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
