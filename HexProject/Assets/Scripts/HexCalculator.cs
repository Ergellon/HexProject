using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexCalculator : MonoBehaviour {


    public Vector2 HexToPixel (int x, int y)
    {
        Vector2 result = new Vector2();
        result.x = x * 3f / 4f;
        result.y = (y + x / 2f) * Mathf.Sqrt(3) * 0.5f;
        return result;
    }

    public Vector2Int MousePositionToHex (Vector3 input)
    {
        Vector3 cubecoords = new Vector3((2f / 3f * input.x * 2f), (-1f / 3f * input.x * 2f + Mathf.Sqrt(3) / 3 * input.y * 2f), -input.x - input.y);

        cubecoords.x = Mathf.Round(cubecoords.x);
        cubecoords.y = Mathf.Round(cubecoords.y);
        cubecoords.z = Mathf.Round(cubecoords.z);

        float x_diff = Mathf.Abs(cubecoords.x - input.x);
        float y_diff = Mathf.Abs(cubecoords.y - input.y);
        float z_diff = Mathf.Abs(cubecoords.z - input.z);

        if ((x_diff > y_diff) && (x_diff > z_diff))
        {
            cubecoords.x = -cubecoords.y - cubecoords.z;
        }
        else
            if (y_diff > z_diff)
        {
            cubecoords.y = cubecoords.x - cubecoords.z;
        }
        else
        {
            cubecoords.z = cubecoords.x - cubecoords.y;
        }

        Vector2Int result = new Vector2Int((int)cubecoords.x, (int)cubecoords.y);
        return result;
    }

}
