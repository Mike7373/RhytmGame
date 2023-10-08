using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _arrow;
    private void Awake()
    {
        SpawnerManager.Instance.spawners.Add(this);
    }
    public void Spawn()
    {
        Instantiate(_arrow, this.transform.position, Quaternion.identity);
    }

    
}
