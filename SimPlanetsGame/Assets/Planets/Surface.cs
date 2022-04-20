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
            UnityEngine.GUI.Label(new Rect(10, 30, 1000, 20), $"Planet: {_planet}");
        }
    }
}