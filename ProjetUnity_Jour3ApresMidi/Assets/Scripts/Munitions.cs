using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Munitions : MonoBehaviour
{
    public int MunitionsCount = 0;

    public Text TxtMunitions;

    void Start() {
        TxtMunitions.text = " " +  MunitionsCount;
    }

    public void AddMunition() {
        MunitionsCount++;

        TxtMunitions.text = " " +   MunitionsCount;
    }

    public void RemoveMunition() {
        MunitionsCount--;

        TxtMunitions.text = " " +   MunitionsCount;
    }

}
