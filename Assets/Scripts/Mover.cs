using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 0f;
    [SerializeField] float zValue = 0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 100 | transform.position.z < 0)
        {
            zValue = -zValue;
        }
        transform.Translate(xValue, yValue, zValue);
    }
}
