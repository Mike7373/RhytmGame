using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer _sp;
    [SerializeField] private Sprite _defaultImage;
    [SerializeField] private Sprite _pressedImage;
    [SerializeField] private KeyCode _keyToPress;
    public bool canBePressed;

    // Start is called before the first frame update
    void Start()
    {
        _sp = GetComponent<SpriteRenderer>();
        canBePressed = false;
}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(_keyToPress))
        {
            _sp.sprite = _pressedImage;
        }
        if (Input.GetKeyUp(_keyToPress))
        {
            _sp.sprite = _defaultImage;
        }
    }

    
}
