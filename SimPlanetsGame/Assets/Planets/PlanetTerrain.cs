using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimPlanet.Core
{ 
    public class PlanetTerrain
    {
        private TerrainTile[,] _tiles;

        public PlanetTerrain(TerrainTile[,] tiles)
        {
            _tiles = tiles;
        }

        public int GetTerrainSize()
        {
            return _tiles.Length;
        }

        public TerrainTile GetTile(int x, int y)
        {
            return _tiles[x, y];
        }
    }
}