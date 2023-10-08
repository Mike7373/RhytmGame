using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    private void OnEnable()
    {
        if(Instance == null)
        {
            Instance= this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Awake()
    {
        GameManager.Instance.audioManager = this;
        gameObject.GetComponent<AudioSource>().clip = GameManager.Instance.track.song;
        gameObject.GetComponent<AudioSource>().pitch = Time.timeScale;
        gameObject.GetComponent<AudioSource>().PlayOneShot(gameObject.GetComponent<AudioSource>().clip);
    }
}
