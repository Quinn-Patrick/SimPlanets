using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimPlanet.Core
{
    public class Planet
    {
        private float _radius;
        private float _density;
        private float _semimajorAxis;

        private PlanetTerrain _terrain;

        public Planet(float radius, float density, float sma)
        {
            _radius = radius;
            _density = density;
            _semimajorAxis = sma;

            _terrain = Utility.GeneratePlanetTerrain(_radius);
        }

        public float GetRadius()
        {
            return _radius;
        }
        public float GetDensity()
        {
            return _density;
        }
        public float GetSemimajorAxis()
        {
            return _semimajorAxis;
        }
        public float GetVolume()
        {
            return (4 / 3) * Mathf.PI * Mathf.Pow(_radius, 3);
        }
        public float GetMass()
        {
            return GetVolume() * GetDensity();
        }
        public float GetSurfaceGravity()
        {
            return Utility.G * (GetMass() / Mathf.Pow(GetRadius(), 2));
        }
        public PlanetTerrain GetTerrain()
        {
            return _terrain;
        }

        override public string ToString()
        {
            return $"r = {_radius} m, V = {GetVolume()}, d = {_density} kg/m^3, m = {GetMass()} kg, a = {_semimajorAxis} AU, g = {GetSurfaceGravity()} m/s^2";
        }
    }
}