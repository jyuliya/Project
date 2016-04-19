using UnityEngine;
using System.Collections;

public class Create : MonoBehaviour
{
    public GameObject obj;

    float timeElapsed = 2f;
    float spawnCycle = 0.3f;
    public bool spawnPowerup = true;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > 2f)
        {
            GameObject temp;
            int zpos = Random.Range(-1, 2);
            for (int i = 0; i < 5; ++i)
            {
                temp = (GameObject)Instantiate(obj);
                Vector3 pos = temp.transform.position;
                temp.transform.position = new Vector3(i, 5, zpos);
                timeElapsed = 0;
            }
        }
    }
}
