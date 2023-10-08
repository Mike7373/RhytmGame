using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public static SpawnerManager Instance;
    public List<Spawner> spawners;

    private void OnEnable()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        StartCoroutine(TimeToSpawn());
    }

    private IEnumerator TimeToSpawn()
    {
        while (AudioManager.Instance.GetComponent<AudioSource>().isPlaying)
        {
            int index = Random.Range(0, spawners.Count);
            spawners[index].Spawn();
            yield return new WaitForSeconds(GameManager.Instance.arrowSpawnSpeed);
        }
    }
}
