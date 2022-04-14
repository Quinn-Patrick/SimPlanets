using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimPlanet.Core
{
    public class Utility
    {
        public static System.Random rand = new System.Random();
        public static readonly float G = 6.67408e-11f;

        

        public static float GetGaussian(float mean, float stdDev)
        {
            float u1 = 1.0f - (float) rand.NextDouble();
            float u2 = 1.0f - (float) rand.NextDouble();
            float randStdNormal = Mathf.Sqrt(-2.0f * (float)Mathf.Log(u1)) * Mathf.Sin(2.0f * Mathf.PI * u2);
            return mean + stdDev * randStdNormal;
        }

        public static Planet GenerateTerrestrialPlanet()
        {
            return new Planet(GetGaussian(1e7f, 3.5e6f), Random.Range(1000f, 6000f),  Random.Range(0.3f, 50f));
        }

        public static PlanetTerrain GeneratePlanetTerrain(float radius)
        {
            int size = Mathf.RoundToInt(radius / 1000000);

            TerrainTile[,] tiles = new TerrainTile[size, size];

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    float fElevation = Mathf.PerlinNoise((float)i / size, (float)j / size);
                    int iElevation = Mathf.FloorToInt(fElevation * 10);
                    tiles[i, j] = new TerrainTile(iElevation);
                }
            }

            PlanetTerrain terrain = new PlanetTerrain(tiles);
            return terrain;
        }
    }
}