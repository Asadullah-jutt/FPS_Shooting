using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
   // public GameObject enemyPrefab; // Prefab of the enemy cube
    public float moveSpeed = 1f; // Speed at which the enemy moves

    GameObject cube;


    public GameObject collide;

    int movementrand = 1;

    Vector3 newPosition;
    public static SpawnEnemy Instance;
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {


        // Spawn the enemy
        //  newPosition = transform.position;
        CreateEnemy();
    }
    public void CreateEnemy()
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // Set the cube's position, rotation, and scale
        int rand = Random.Range(-10, 10);
        cube.transform.position = new Vector3(rand, rand, rand);
        cube.transform.rotation = Quaternion.identity;
        cube.transform.localScale = new Vector3(3f, 3f, 3f);
        cube.transform.SetParent(gameObject.transform);
        cube.tag = "EEEEE";
        movementrand = Random.Range(0, 3);

        // Add a collider component to the cube
        BoxCollider cubeCollider = cube.AddComponent<BoxCollider>();

        // Add a Rigidbody component to the cube
        Rigidbody cubeRigidbody = cube.AddComponent<Rigidbody>();
        Renderer cubeRenderer = cube.GetComponent<Renderer>();
        if (cubeRenderer != null)
        {
            Material cubeMaterial = new Material(Shader.Find("Standard"));
            cubeMaterial.color = Color.black;
            cubeRenderer.material = cubeMaterial;
        }
    }


    public void setSize(float size)
    {
        Vector3 newScale = new Vector3(size, size, size);
        cube.transform.localScale = newScale;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the enemy along the x-axis
        if (cube != null)
        {
            if (movementrand == 1)
                newPosition.z = ((moveSpeed * Time.deltaTime) + cube.transform.position.z);
            else if (movementrand == 2)
                newPosition.x = ((moveSpeed * Time.deltaTime) + cube.transform.position.x);
            else if (movementrand == 3)
            {
                newPosition.x = ((moveSpeed * Time.deltaTime) + cube.transform.position.x);
                newPosition.z = ((moveSpeed * Time.deltaTime) + cube.transform.position.z);
            }


            cube.transform.position = newPosition;
        }
    }

    private void OnDestroy()
    {
        Instantiate(collide, transform.position,transform.rotation);
    }
}