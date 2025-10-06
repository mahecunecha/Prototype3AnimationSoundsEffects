using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab; // estamos guardando en la variable el objeto que queremos instanciar
    public Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);// este metodo nos deja llamar repetidamente a "SpawnObstacle" con un intervalo de tiempo fijo entre cada llamada

    }

    // Update is called once per frame
    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); // el prefab, la posicion, y la rotacion del prefab usado

    }
}
