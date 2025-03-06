using UnityEngine;
using System.Collections;

public class CoinSpawner : MonoBehaviour
{
    public Vector3 boundary1;
    public Vector3 boundary2;
    public GameObject coinPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       StartCoroutine(SpawnCoins()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCoins(){
        while(true){
            SpawnCoinFunc();
            yield return new WaitForSeconds(Random.Range(2f, 5f));
        }
    }

    private void SpawnCoinFunc() {
        Vector3 spawnPosition = new Vector3(
            Random.Range(boundary1.x, boundary2.x),
            5f,
            Random.Range(boundary1.z, boundary2.z)
        );
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }
}
