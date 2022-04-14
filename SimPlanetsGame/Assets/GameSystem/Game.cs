using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimPlanet.Core
{
    public class Game : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log(Utility.GenerateTerrestrialPlanet());
            }
        }
    }
}