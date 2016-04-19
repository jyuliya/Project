using UnityEngine;
using System.Collections;

public class GroundCreate : MonoBehaviour
{
    public GameObject obj;

    float timeElapsed = 2f;
    float spawnCycle = 0.3f;
    public bool spawnPowerup = true;

    void Update()
    {
        timeElapsed += 0.02f;
        if (timeElapsed > 0.4f)
        {
            GameObject temp;
                temp = (GameObject)Instantiate(obj);
                Vector3 pos = temp.transform.position;
                temp.transform.position = new Vector3(0, 4, 0);
                timeElapsed = 0;
        }
    }
}
