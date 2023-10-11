using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public AudioManager audioManager;
    public SongSO track;
    public int difficulty = 1;  //Si potrebbe fare con un enum
    public float arrowMovSpeed;
    public float arrowSpawnSpeed;
    public Score scoreText;
    public int score;

    private void OnEnable()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Awake()
    {
        Time.timeScale = 1f + difficulty / 10f;
    }
    private void Start()
    {
        score = 0;
        arrowMovSpeed = track.bpm / 30f;
        arrowSpawnSpeed =  1f / arrowMovSpeed;
    }

}
