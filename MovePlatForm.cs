using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatForm : MonoBehaviour
{
    Vector3 startPos;

    public float speed = 2f;
    public float height = 2f;
    public Transform scaleFix;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            other.transform.SetParent(scaleFix);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            other.transform.SetParent(null);
        }
    }
    void Awake()
    {
        scaleFix.localScale = new Vector3(
            1f / transform.localScale.x,
            1f / transform.localScale.y,
            1f / transform.localScale.z
        );
    }
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float z = Mathf.Sin(Time.time * speed) * height;

        transform.position = startPos + new Vector3(0, 0, z);
    }


}
