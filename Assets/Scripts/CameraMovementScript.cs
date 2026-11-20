using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    [SerializeField] private GameObject cameraSubject;
    private Vector3 subjectPosition;
    private Vector3 lastPosition = Vector3.zero;
    private float movementSpeed = 1.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        subjectPosition = cameraSubject.transform.position;
        movementSpeed = new Vector2(subjectPosition.x - lastPosition.x, subjectPosition.y - lastPosition.y).magnitude * Time.deltaTime * 100;
        
        transform.position = new Vector3(subjectPosition.x, subjectPosition.y, -10 -movementSpeed);
        
        lastPosition = subjectPosition;
    }
}
