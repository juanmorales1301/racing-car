using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerEfecto : MonoBehaviour
{
    public List<GameObject> fallingObjectPrefabs;  // Lista de Prefabs de objetos que caen
    public float spawnRate = 1f;  // la tasa en la que los objetos caerán
    public float objectSpeed = 2f;  // velocidad del objeto
    public float xRangeIni = 2f;
    public float xRangeFin = 2f;
    public float yRangeIni = 2f;
    public float yRangeFin = 2f;

    private float nextSpawnTime;

    private void Update()
    {
        if (ShouldSpawn())
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        objectSpeed = objectSpeed + 0.01f;
        spawnRate = spawnRate + -0.01f;


        if(fallingObjectPrefabs.Count == 0) // verifica si la lista está vacía
        {
            Debug.LogError("No hay prefabs en la lista fallingObjectPrefabs. Asegúrate de agregar prefabs a esta lista en el inspector de Unity.");
            return;
        }
        
        nextSpawnTime = Time.time + Random.Range(spawnRate, 1);

        float spawnPositionX = Random.Range(xRangeIni, xRangeFin);
        float spawnPositionY = Random.Range(yRangeIni, yRangeFin);
        Vector2 spawnPosition = new Vector2(spawnPositionX, spawnPositionY);

        int randomIndex = Random.Range(0, fallingObjectPrefabs.Count);
        GameObject randomPrefab = fallingObjectPrefabs[randomIndex];

        GameObject spawnedObject = Instantiate(randomPrefab, spawnPosition, Quaternion.identity);
        Rigidbody2D rb = spawnedObject.GetComponent<Rigidbody2D>();

        // Asegúrate de que tu objeto tenga un Rigidbody2D para que este código funcione
        if (rb != null)
        {
            rb.velocity = new Vector2(0, -objectSpeed);
        }
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }
}
