using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerShoot : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerWeapon weapon;
    public Text scoretext;
    //   public GameObject obstacle;
    private int temp;
    [SerializeField]
    Camera cam;
    public GameObject bullet;
    public GameObject collide;

    Vector3 pos_store;
    public Transform gunfire;

    [SerializeField]
    LayerMask mask;
    void Start()
    {
        if (cam == null)
        {
            Debug.LogError("PlayerShoot !! No camera Referenced");
            this.enabled = false;
        }
        temp = 0;

        

    }


    GameObject DestroyObjll;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
         //   Debug.Log(transform.forward);
            //  collide.transform.position = cam.transform.position;
            pos_store = gunfire.position;
            //pos_store.x = pos_store.x + 1f;
            //pos_store.z = pos_store.z + 2f;
           // Instantiate(bullet, gunfire.position, Quaternion.identity);
            Instantiate(collide, pos_store, gunfire.rotation);
        //    CancelInvoke(nameof(DestroyObj));
         //   Invoke(nameof(DestroyObj), 1f);
        }
    }
    //public void DestroyObj()
    //{
    //    Destroy(DestroyObjll);

    //}
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, weapon.range, mask))
        {
            Debug.Log("We Hit " + hit.collider.name);
            if (hit.collider.tag == "EEEEE")
            {
                scoretext.text = temp.ToString();
                Debug.Log("We Hit " + hit.collider.tag);
                Destroy(hit.collider.gameObject);
                SpawnEnemy.Instance.CreateEnemy();
                //  Destroy(obstacle);
                temp++;
                int a = - 1 ;
                PlayerPrefs.SetInt("newScore", temp);
                Debug.Log(PlayerPrefs.GetInt("newScore"));
               // temp = a;
            }
            ///Instantiate(obstacle, Vector3.one, gunfire.rotation);
        }
      //  Vector3 fire;
        //  fire = new Vector3(0, 0, 20);

    }
}
