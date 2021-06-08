using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonScript : MonoBehaviour
{




    void Update()
    {

        transform.Translate(Vector3.back * Time.deltaTime * 0.2f);

    }




}
