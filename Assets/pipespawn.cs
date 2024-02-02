using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawn : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float height = 0.45f;
    [SerializeField] private GameObject pipeCheck;

    private float timer;
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-height, height));
        GameObject Pipes = Instantiate(pipeCheck, spawnPos, Quaternion.identity);

        Destroy(Pipes,10f);
    }
}
