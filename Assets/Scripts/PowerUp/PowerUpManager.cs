using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public int spawnIntervalPU;
    private float timer;

    public bool playGame;
    public bool gameOver;

    [Header("Spawn List")]
    public List<GameObject> spawnArea;
    public Transform spawnParent;

    [Header("PowerUp List")]
    public List<GameObject> powerUpList;
    public int maxPU;

    // Start is called before the first frame update
    void Start()
    {
        GeneratePUList();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnIntervalPU)
        {
            GeneratePUList();
            timer -= spawnIntervalPU;

        }
    }

    public void GeneratePUList()
    {
        int randomSpawnArea = Random.Range(0, spawnArea.Count);
        int randomIndex = Random.Range(0, powerUpList.Count);
        GameObject powerUp = Instantiate(powerUpList[randomIndex], spawnArea[randomSpawnArea].transform.position, spawnArea[randomSpawnArea].transform.localRotation, spawnParent);
        powerUp.SetActive(true);
    }
}
