using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5.0f;
    [SerializeField]
    private int experience = 3;
    private LevelUpSystem levelUpSystem;
    
    void Start() {
        levelUpSystem = GameObject.Find("Fortress").GetComponent<LevelUpSystem>();
    }

    void Update() {
        float horizontalInput = 1f;
        float verticalInput = 0f;
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0f);
        transform.Translate(direction * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(levelUpSystem != null) {
            levelUpSystem.addExperience(experience);
        }
    }
}
