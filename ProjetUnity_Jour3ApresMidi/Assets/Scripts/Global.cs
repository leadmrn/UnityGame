using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    public float Speed = 1;

    public float Intervalle = 10;
    float TempsPasse = 0;

    // Update is called once per frame
    void Update()
    {

        TempsPasse += Time.deltaTime;
        if (TempsPasse > Intervalle) {
            Speed++;
            TempsPasse = 0;
        }
    }
}
