using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimPlanet.Core
{
    public class TerrainTile
    {
        private int _elevation;

        public TerrainTile(int elevation)
        {
            _elevation = elevation;
        }

        public float GetElevation()
        {
            return _elevation;
        }
    }
}