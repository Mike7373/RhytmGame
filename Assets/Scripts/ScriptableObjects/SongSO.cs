using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New song", fileName = "SongName")] 
public class SongSO : ScriptableObject
{
    public AudioClip song;
    public int bpm;
}
