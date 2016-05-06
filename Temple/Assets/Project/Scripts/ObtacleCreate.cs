using UnityEngine;
using System.Collections;

public class ObtacleCreate : MonoBehaviour
{
    public GameObject obj;

    float timeElapsed = 2f;
    float spawnCycle = 0.3f;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > 0.9f)
        {
            GameObject temp;

            int z = Random.Range(-1, 2);
            temp = (GameObject)Instantiate(obj);
            Vector3 pos = temp.transform.position;
            temp.transform.position = new Vector3(1, 4, z);
            timeElapsed = 0;
        }
    }
}
