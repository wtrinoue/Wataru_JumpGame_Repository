using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackStartPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //初期位置に配置
        transform.position = new Vector3(-7,-3,0);
    }

    // Update is called once per frame
    void Update()
    {
        float playerYPos = transform.position.y;
        if (playerYPos <= -5.0f)
        {
            transform.position = new Vector3(-7,-3,0);
        }
    }
}
