using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;

    [SerializeField] private Tile _tilePrefabOffset, _tilePrefab, _mountaintile;

    [SerializeField] private Transform _cam;

    Tile spawnededfile;

    private void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < _width; x++)
        {
            for(int z =0; z < _height; z++)
            {
                //var isOffset = (x + z) % 2 == 1;
                var RandomTile = Random.Range(0, 6);
                switch (RandomTile)
                {
                    case 3:
                        spawnededfile = Instantiate(_mountaintile, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                    default:
                        spawnededfile = Instantiate(_tilePrefabOffset, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                }
                    spawnededfile.name = $"Tile {x} {z}";               
            }
        }
        _cam.transform.position = new Vector3((float)_width / 2 - 0.5f,10 ,(float)_height / 2 - 0.5f);
    }

}
