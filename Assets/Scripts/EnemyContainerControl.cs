using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainerControl : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float xMinPosition;
    public float xMaxPosition;
    public float yPosition;
    public int TimeToCreateEnemy;
    public GameManager GameManager;
    // Start is called before the first frame update
    void Start()
    {
        xMinPosition = -6.5f;
        xMaxPosition = 6.5f;
        TimeToCreateEnemy = 4;
        yPosition = 6;

        CreateEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateEnemy()
    {
        float xPosition = Random.Range(xMinPosition, xMaxPosition);
        Vector2 PositionToCreate = new Vector2(xPosition, yPosition);
        GameObject clone = Instantiate(enemyPrefab, PositionToCreate, transform.rotation);
        clone.transform.SetParent(this.transform);
        clone.GetComponent<EnemyController>().SetGameManager(GameManager);
        Invoke("CreateEnemy", TimeToCreateEnemy);
    }
}
