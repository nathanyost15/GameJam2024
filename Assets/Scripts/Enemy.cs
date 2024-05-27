using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int experience = 3;
    private LevelUpSystem levelUpSystem;
    
    void Start() {
        levelUpSystem = GameObject.Find("Fortress").GetComponent<LevelUpSystem>();
    }

    void Update() {
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(levelUpSystem != null) {
            levelUpSystem.addExperience(experience);
        }
    }
}
