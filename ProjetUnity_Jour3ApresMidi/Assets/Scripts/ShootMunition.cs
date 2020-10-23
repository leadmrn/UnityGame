using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMunition : MonoBehaviour
{

    public GameObject[] ObjPrefabs;
    Munitions Mun;

    public int Min = 0;
    public int Max = 0;

    public AudioSource shootSound;

    // Start is called before the first frame update
    void Start()
    {
        Mun = GetComponent<Munitions>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && Mun.MunitionsCount >= 1){
            int index = Random.Range(0, ObjPrefabs.Length);
            GameObject spawnee = GameObject.Instantiate(ObjPrefabs[index]);
            Vector3 spawnerPos = transform.position;
            spawnerPos.x += Random.Range(Min, Max);
            spawnee.transform.position = spawnerPos;
            Mun.RemoveMunition();

            shootSound.Play();
        };
    }
}
