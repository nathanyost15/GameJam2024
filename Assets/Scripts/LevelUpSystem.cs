using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpSystem : MonoBehaviour
{
    private int level;
    private int experience;

    void Start() {
        experience = 0;
    }

    void Update() {
        if (experience > 10) {
            experience = 0;
            level++;
            Debug.Log("leveled up! Level: " + level);
        }
    }

    public void addExperience(int experience) {
        this.experience += experience;
    }

    public int getExperience() { return experience; }
}
