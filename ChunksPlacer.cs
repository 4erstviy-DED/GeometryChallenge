using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunksPlacer : MonoBehaviour
{
    public Transform Player; //объект игрока
    public Chunk[] ChunkPrefabs; //массив вариантов которые можно заспавнить
    public Chunk FirstChunk;

    private List<Chunk> spawnedChunks = new List<Chunk>(); //массив чанков уже заспавненых

    void Start()
    {
        spawnedChunks.Add(FirstChunk);
    }

    private void Update()
    {
        if(Player.position.z > spawnedChunks[spawnedChunks.Count - 1].End.position.z - 100) //условие спавна чанка
        {
            SpawnChunk();
        }
    }

    private void SpawnChunk()
    {
        Chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]); //создание объекта чанка
        newChunk.transform.position = spawnedChunks[spawnedChunks.Count -1].End.position - newChunk.Begin.localPosition * 2.5f; // положение чанка (домножение newChunk.Begin.localPosition зависит от scale чанков)
        spawnedChunks.Add(newChunk); //добавление в массив который уже содержит существующие куски уровня

        //удаление пройденных чанков
        if (spawnedChunks.Count >= 10)
        {
            Destroy(spawnedChunks[0].gameObject);
            spawnedChunks.RemoveAt(0);
        }
    }
}
