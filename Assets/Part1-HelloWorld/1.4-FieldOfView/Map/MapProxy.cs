﻿
using System.Runtime.CompilerServices;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

namespace RLTKTutorial.Part1_4
{
    public struct MapData : IComponentData
    {
        public int width;
        public int height;
        public int2 Size => new int2(width, height);
    }

    public class MapProxy : MonoBehaviour, IConvertGameObjectToEntity
    {
        [SerializeField]
        int _width = 80;
        [SerializeField]
        int _height = 50;
        
        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            dstManager.AddComponentData(entity, new MapData
            {
                width = _width,
                height = _height,
            });

            var buffer = dstManager.AddBuffer<MapTiles>(entity);
            
        }

        private void OnDrawGizmos()
        {
            Rect r = new Rect(0, 0, _width, _height);
            r.position = -new Vector2(_width, _height) * .5f;

            Vector3 pos = r.center;
            Vector3 size = new Vector3(_width, _height, 1);

            Gizmos.color = Color.blue;
            Gizmos.DrawWireCube(pos, size);
        }
    }

}