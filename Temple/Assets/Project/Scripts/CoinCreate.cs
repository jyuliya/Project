using UnityEngine;
using System.Collections;

public class CoinCreate : MonoBehaviour
{
    public GameObject obj;

    float timeElapsed = 2f;
    float spawnCycle = 0.3f;
    public bool spawnPowerup = true;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > 0.5f)
        {
            GameObject temp;                
            
            int z = Random.Range(-1, 2);
            
            for (int i = 1; i < 6; ++i)
            {
                temp = (GameObject)Instantiate(obj);
                Vector3 pos = temp.transform.position;
                temp.transform.position = new Vector3(i, 5, z);                
            }
            timeElapsed = 0;
        }
    }
}
