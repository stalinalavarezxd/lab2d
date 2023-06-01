using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public GameObject levelFinish;
    public GameObject cofre;
    // Start is called before the first frame update
    void Start()
    {
        cofre.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount ==1)
        {
            cofre.SetActive(true);
        }
    }
}
