using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class susenemy : MonoBehaviour
// https://www.youtube.com/watch?v=ydjpNNA5804

{
    public GameObject Enemy;
    public int zPos;
    public int xPos;
    public int EnemyCount;
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop()
    {
        while (EnemyCount < 10)
        {
            xPos = Random.Range(10, 3);
            zPos = Random.Range(10,2);
            Instantiate(Enemy, new Vector3(xPos, 7, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            EnemyCount += 1;
        }
    }

}