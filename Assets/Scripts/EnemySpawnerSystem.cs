using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyTemplate;
    private float secondsToSpawnNewWave;
    private int unitsInWave;


    void Start() {
        secondsToSpawnNewWave = 5f;
        unitsInWave = 1;
    }

    void Update() {
        if (enemyTemplate != null) {
            secondsToSpawnNewWave -= Time.deltaTime;
            if (secondsToSpawnNewWave <= 0) {
                secondsToSpawnNewWave = 5f;
                for (int i = 0; i < unitsInWave; i++) {
                    Debug.Log("Spawning enemies!");
                    Instantiate(enemyTemplate, transform, false);
                }
            }
        }
    }
}
