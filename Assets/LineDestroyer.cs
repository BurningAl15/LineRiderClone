using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDestroyer : MonoBehaviour {

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
