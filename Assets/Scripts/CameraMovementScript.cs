using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    [SerializeField] private GameObject cameraSubject;
    private Vector3 subjectPosition;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        subjectPosition = cameraSubject.transform.position;
        transform.position = new Vector3(subjectPosition.x, subjectPosition.y, -10);
    }
}
