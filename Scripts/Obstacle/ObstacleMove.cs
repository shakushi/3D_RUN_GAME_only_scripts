using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    private float moveLimit = 50f;
    private float speed = 5.0f;
    private float startPosZ;

    // Start is called before the first frame update
    void Start()
    {
        startPosZ = this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
        if (startPosZ - this.transform.position.z >= moveLimit)
        {
            Destroy(this.gameObject);
        }
    }
}
