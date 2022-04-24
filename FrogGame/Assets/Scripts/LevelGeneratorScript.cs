using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneratorScript : MonoBehaviour
{

    public List<Transform> listOfLevels = new List<Transform>();
    public Transform entryLevel;
    public Vector3 offsetPosition;
    public float SPAWNING_DISTANCE;
    public Player target;

    private Vector3 endPosition;
    // Start is called before the first frame update
    void Start()
    {
        endPosition = entryLevel.Find("EndPosition").position;
        endPosition.x += offsetPosition.x;
        endPosition.y += offsetPosition.y;

        for(int i = 0; i < 5; ++i){
            SpawnLevelPart();
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(target.GetPosition(), endPosition) < SPAWNING_DISTANCE){
            SpawnLevelPart();
        }
        
    }

    private void SpawnLevelPart(){
        Transform lastLevelPart = InstantiateLevelPart(endPosition);
        endPosition = lastLevelPart.Find("EndPosition").position;
        endPosition.x += offsetPosition.x;
        endPosition.y = (endPosition.y) + offsetPosition.y + Random.Range(-1, 1f);
    }

    private Transform InstantiateLevelPart(Vector3 spawnPosition){
        int levelIndex = Random.Range(0, listOfLevels.Count - 1);

        Transform levelPartGameObject = Instantiate(listOfLevels[levelIndex], spawnPosition, Quaternion.identity);
        return levelPartGameObject;
    }


}
