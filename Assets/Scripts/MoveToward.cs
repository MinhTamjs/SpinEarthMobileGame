using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToward : MonoBehaviour
{
    public string WayPoint;
    private GameObject Toward;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Toward = GameObject.FindWithTag(WayPoint);
    }

    // Update is called once per frame
    void Update()
    {
        if (Toward != null)
        transform.position = Vector3.MoveTowards(transform.position, Toward.transform.position, speed * Time.deltaTime);
    }
}
