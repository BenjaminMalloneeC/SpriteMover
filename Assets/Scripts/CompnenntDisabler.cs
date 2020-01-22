using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompnenntDisabler : MonoBehaviour
{ 
    public Mover spriteMover;
    // Start is called before the first frame update
    void Start()
    {
        spriteMover = gameObject.GetComponent<Mover>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            spriteMover.enabled = (!spriteMover.enabled);
        }
    }
}
