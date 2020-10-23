using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreResult : MonoBehaviour
{

    public Text TxtScore;

    // Start is called before the first frame update
    void Start()
    {
        TxtScore.text = "Score: " + Scoring.FinalScore + "m";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
