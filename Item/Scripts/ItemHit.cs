using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHit : MonoBehaviour
{
    public string tag = "Player";
    public string tag2 = "Player";
    float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == tag)
        {
            Destroy(col.gameObject);
            Move.AddSpeed(30.0f);
        }

        if (col.gameObject.tag == tag2)
        {
            Destroy(col.gameObject);
            Move.AddNotSpeed(30.0f);
        }
    }
}
