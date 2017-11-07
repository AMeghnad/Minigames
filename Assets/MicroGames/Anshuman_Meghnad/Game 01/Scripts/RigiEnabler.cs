using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StirlingMulvey;

namespace AnshumanMeghnad
{

    public class RigiEnabler : MonoBehaviour
    {
        Rigidbody myRigi;

        // Use this for initialization
        void Start()
        {
            myRigi = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            myRigi.isKinematic = !GlobalGameManager.gameActive;
        }
    }
}
