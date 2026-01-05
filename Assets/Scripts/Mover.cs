using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    
    void Start()
    {
        PrintInstructions();
    }
    
    void Update()
    {
        MovePlayer();
    }

    private static void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using arrow keys or wasd");
        Debug.Log("Don't bump into objects!");
    }

    private void MovePlayer()
    {
        var xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        const float yValue = 0f;
        var zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        transform.Translate(xValue, yValue, zValue);
    }
}
