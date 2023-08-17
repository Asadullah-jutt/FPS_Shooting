using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke(nameof(DestroyObjjj), 1f);
    }
    public void DestroyObjjj()
    {
        Destroy(gameObject);
    }
}
