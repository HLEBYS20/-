using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
        public int HP = 5;

        public int lvl = 10;

        public float speed = 1.2f;
    
    void Start()
    {
        HP+=lvl;
        print("здоровье:"+HP);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition=transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
