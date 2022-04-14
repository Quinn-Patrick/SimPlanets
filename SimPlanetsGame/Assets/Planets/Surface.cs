using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace SimPlanet.Core
{
    public class Surface : MonoBehaviour
    {
        [SerializeField] private Planet _planet;
        [SerializeField] private Grid _grid;
        [SerializeField] private Tilemap _tiles;


        [SerializeField] private TileBase[] _tileBase;

        private void Start()
        {
            _planet = Utility.GenerateTerrestrialPlanet();
            int scale = _planet.GetTerrain().GetTerrainSize();
            for(int i = 0; i < scale; i++)
            {
                for (int j = 0; j < scale; j++)
                {
                    _tiles.SetTile(new Vector3Int(i, j, 0), _tileBase[Random.Range(0, _tileBase.Length - 1)]);
                }
            }
        }

        private void OnGUI()
        {
            GUI.Label(new Rect(10, 20, 1000, 20), $"Planet: {_planet}");
        }

        /*
        private Sprite EvaluateTile(int x, int y)
        {
            TerrainTile Origin = _planet.GetTerrain().GetTile(x, y);

            TerrainTile Northwest = _planet.GetTerrain().GetTile(x - 1, y + 1);
            TerrainTile North = _planet.GetTerrain().GetTile(x, y + 1);
            TerrainTile Northeast = _planet.GetTerrain().GetTile(x + 1, y + 1);
            TerrainTile West = _planet.GetTerrain().GetTile(x - 1, y);
            TerrainTile East = _planet.GetTerrain().GetTile(x + 1, y);
            TerrainTile Southwest = _planet.GetTerrain().GetTile(x - 1, y - 1);
            TerrainTile South = _planet.GetTerrain().GetTile(x, y - 1);
            TerrainTile Southeast = _planet.GetTerrain().GetTile(x + 1, y - 1);

            Sprite output = null;

            string slopeType = "";

            if(North.GetElevation() > Origin.GetElevation())
            {
                slopeType = slopeType + "south";
                if(West.GetElevation() > Origin.GetElevation())
                {
                    slopeType = slopeType + "east";
                }
                if (East.GetElevation() > Origin.GetElevation())
                {
                    slopeType = slopeType + "west";
                }
            }
            else if (North.GetElevation() < Origin.GetElevation())
            {
                slopeType = slopeType + "south";
                if (East.GetElevation() < Origin.GetElevation())
                {
                    slopeType = slopeType + "east";
                }
                if (West.GetElevation() < Origin.GetElevation())
                {
                    slopeType = slopeType + "west";
                }
            }
            else if (West.GetElevation() > Origin.GetElevation())
            {
                slopeType = slopeType + "east";
            }
            else if (West.GetElevation() < Origin.GetElevation())
            {
                slopeType = slopeType + "west";
            }
            _slopes.TryGetValue(slopeType, out output);
            return output;
        }
        */
    }
}