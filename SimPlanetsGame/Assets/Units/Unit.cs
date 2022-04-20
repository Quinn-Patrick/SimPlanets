using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimPlanet.Core
{
    public class Unit
    {
        [SerializeField] private string unitName;

        public string GetName()
        {
            return unitName;
        }
    }
}