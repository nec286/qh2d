using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeder
{
  private int x, y, w, h;

  public Seeder(int x, int y, int w, int h) {
    this.x = x;
    this.y = y;
    this.w = w;
    this.h = h;
  }

  public List<Vector3> Generate() {
    List<Vector3> points = new List<Vector3>();   
    for (int i = x; i < w; i++) {
      for (int j = y; j < h; j++) {
        points.Add(new Vector3(i + Random.value, j + Random.value, 0));
      }
    }
    return points;
  }
}