using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("DestroyEffect", 0.5f);
    }

    private void DestroyEffect()
    {
        Destroy(gameObject);
    }
}
