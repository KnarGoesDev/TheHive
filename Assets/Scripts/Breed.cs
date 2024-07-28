using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Breed {
    private float health;
    private float strength;
    private float agility;
    private float intelegence;
    private float score ;
    private List<float> stats;
    private float randomFactor = 0.05f;
    
    
    public Breed (float QueenScore){
        health = QueenScore+Random.Range(QueenScore*-randomFactor,QueenScore*randomFactor);
        strength = QueenScore+Random.Range(QueenScore*-randomFactor,QueenScore*randomFactor);
        agility = QueenScore+Random.Range(QueenScore*-randomFactor,QueenScore*randomFactor);
        intelegence = QueenScore+Random.Range(QueenScore*-randomFactor,QueenScore*randomFactor);
        score = (health+strength+agility+intelegence)/4f;
        stats = new List<float> {score,health,strength,agility,intelegence};
    }

    public List<float> GetStats(){
        
        return stats;
    }

    public float GetScore(){
        return score;
    }
    }
    

