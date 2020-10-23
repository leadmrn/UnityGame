using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{

    public float Intervalle = 1;
    float TempsPasse = 0;

    public int Score = 0;

    public Text TxtScore;

    public static int FinalScore;

    void Start() {
        TxtScore.text = " " +  Score;
    }

    // Update is called once per frame
    void Update()
    {

        TempsPasse += Time.deltaTime;
        if (TempsPasse > Intervalle) {
            Score++;
            TxtScore.text = " " +  Score;
            Scoring.FinalScore = Score;
            TempsPasse = 0;
        }
    }

    public void MalusScore(){
        Score -= 5;
    }
}
