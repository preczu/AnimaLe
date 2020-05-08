using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] fruits;

    private BoxCollider col;

    float x1,x2;

    void Awake()
    {
        col = GetComponent<BoxCollider>();

        x1 = transform.position.x - col.bounds.size.x /2f;
        x2 = transform.position.x + col.bounds.size.x /2f;
    }

    void Start()
    {
        StartCoroutine (SpawnFruit(1f));
    }

    //coroutine

    IEnumerator SpawnFruit(float time) {
        yield return new WaitForSeconds(time); 

        Vector3 temp = transform.position;
        temp.x = Random.Range (x1, x2);

        GameObject fruit = fruits[Random.Range(0, fruits.Length)];
        //fruit 

        Instantiate (fruit, temp, Quaternion.identity);
        //Instantiate (fruits[Random.Range(0, fruits.Length)], temp, Quaternion.identity);
        //fruit.transform.rotation = Quaternion.Euler(new Vector3(90, 90, 90)); //rotation not working
        //StartCoroutine (SpawnFruit(Random.Range(10f, 20f)));
        StartCoroutine (SpawnFruit(4f));
	}



}
