using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapgGrid : MonoBehaviour
{

    [SerializeField] private int _width, _height;
    [SerializeField] private float _positionOffset;
    [SerializeField] private tile _tilePrefab;
    [SerializeField] private Transform _parentGrid;
    private Dictionary<Vector2,tile> _tiles;

    void GenerateGrid()
    {
        _tiles = new Dictionary<Vector2,tile>();
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                tile SpawnedTile = Instantiate(_tilePrefab, new Vector3(x + _positionOffset, y + _positionOffset), Quaternion.identity, _parentGrid);
                SpawnedTile.name = $"Tile {x} {y}";

                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                SpawnedTile.Init(isOffset);
                _tiles.Add(new Vector2(x + _positionOffset, y + _positionOffset), SpawnedTile);
            }
        }
    }

    public tile GetTileAtPosition(Vector2 position)
    {
        if(_tiles.TryGetValue(position,out var tile)) {
            Debug.Log(tile);
            return tile;
               
        }
    return null; 
        


    }
    // Start is called before the first frame update
    void Start()
    {
                GenerateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
