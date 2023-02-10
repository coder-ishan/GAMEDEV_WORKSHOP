using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject coin;
    private GameObject instcoin;
    public GameObject dedCoinPrefab;
    private GameObject dedCoin;
    float time;
    float timeDelay;
    float x,z;

    void Start()
    {
        time = 0f;
        timeDelay = 2f;
    }
    
    // Update is called once per frame
    void Update()
    {
        x = (Random.Range(-4, 4));
        z = (Random.Range(-4, 4));
        time = time + 1f * Time.deltaTime;
        
        Debug.Log((int)(Time.deltaTime * 1000000) % 1000);
        if ((int)(Time.deltaTime * 1000000) % 1000 == 312)
        {
            dedCoin = Instantiate(dedCoinPrefab, new Vector3(x, -1.5f, z), Quaternion.identity);
            Destroy(dedCoin,2f);
        }
        if(time >= timeDelay)
        {
           
            instcoin = Instantiate(coin, new Vector3(x, -1.5f, z), Quaternion.identity);
            Destroy(instcoin,5f);
            time = 0;
        }
        

        
    }
}
