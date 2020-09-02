using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private float _speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 arrowRotation = new Vector3(0, -90, 0);
        //this.transform.rotation = arrowRotation;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.back * _speed * Time.deltaTime);

        if (this.transform.position.x >= 160)
        {
            Destroy(this.gameObject);
        }
    }
}
