using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Distribution2D
{

  public List<Vector3> points = new List<Vector3>();

  private Grid grid;

  public Distribution2D(Grid grid)
  {
    this.grid = grid;
  }

  public void Generate()
  {
    points.Clear();
    for (int i = grid.xMin; i < grid.xMax; i++)
    {
      for (int j = grid.yMin; j < grid.yMax; j++)
      {
        this.points.Add(new Vector3(i + Random.value, j + Random.value, 0));
      }
    }
  }

}
