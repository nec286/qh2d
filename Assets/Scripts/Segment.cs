using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segment {

  public Vector3 a;
  public Vector3 b;

  public Segment(Vector3 a, Vector3 b) {
    this.a = a;
    this.b = b;
  }

  public float GetDistanceToPoint(Vector3 point) {
    return Mathf.Abs((b.x - a.x) * (a.y - point.y) - (a.x - point.x) * (b.y - a.y)) / 
      Mathf.Sqrt(Mathf.Pow(b.x - a.x, 2) + Mathf.Pow(b.y - a.y, 2));
  }

  public bool GetSide(Vector3 point) {
    return point != a && point != b && 
      Mathf.Sign((b.x - a.x) * (point.y - a.y) - (b.y  - a.y) * (point.x - a.x)) == 1;
  }

}
