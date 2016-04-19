using UnityEngine;
using System.Collections;

public class CreateIsland : MonoBehaviour
{
    public GameObject obj;

    float timeElapsed = 7f;
    float spawnCycle = 0.3f;
    public bool spawnPowerup = true;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > 7f)
        {
            
            int  z = Random.Range(0, 10);
            if (z > 5)
            {
                GameObject temp;
                temp = (GameObject)Instantiate(obj);
                Vector3 pos = temp.transform.position;
                temp.transform.position = new Vector3(0, 3, 3);
                
            }
            else {
                GameObject temp;
                temp = (GameObject)Instantiate(obj);
                Vector3 pos = temp.transform.position;
                temp.transform.position = new Vector3(0, 3, -3);
                
            }
            timeElapsed -= 7f;
        }
    }
}
