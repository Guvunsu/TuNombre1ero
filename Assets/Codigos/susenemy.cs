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
    IEnumerator EnemyDrop() //checar esto con el profesor 
    {
        while (EnemyCount < 10)
        {
            xPos = Random.Range(100, 0);
            zPos = Random.Range(0,100);
            Instantiate(Enemy, new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            EnemyCount += 20;

        }
        void OnCollisionEnter(Collision collision)
        {
            Destroy(collision.gameObject);
        }
    }

}