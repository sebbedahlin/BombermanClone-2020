using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject tile;

    [SerializeField]
    int width = 8;

    [SerializeField]
    int height = 8;

    // Start is called before the first frame update
    void Start()
    {
        int width = 8;
        int height = 8;

        Vector3 offset = new Vector3(
            -width/2f + 0.5f,
            -height/2f + 0.5f
            );

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                MakeTile(offset, x, y);
            }
        }
    }

    protected virtual void MakeTile(Vector3 offset, int x, int y)
    {
        GameObject newTile = Instantiate(tile,
            new Vector3(x, y, transform.position.z) + offset,
            Quaternion.identity);

        newTile.name = tile.name + " " + x + "," + y;
        newTile.transform.parent = transform;
    }
}
