using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10f;
    public GameObject projectilePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x>xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation);
        }
    }
}
