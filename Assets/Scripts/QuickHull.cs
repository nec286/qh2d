using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class QuickHull {

  private List<Vector3> hull;

  public List<Vector3> FindHull(List<Vector3> points) {
    hull = new List<Vector3>();

    Vector3 a = points.Min(point => point.x);
    Vector3 b = points.Max(point => point.x);

    hull.Add(a);
    hull.Add(b);

    FindHull(points.FindAll((new Segment(a, b)).GetSide), a, b);
    FindHull(points.FindAll((new Segment(b, a)).GetSide), b, a);

    return hull;
  }

  private void FindHull(List<Vector3> points, Vector3 p, Vector3 q) {
    if(points.Count == 0) return;

    Segment pq = new Segment(p, q);
    Vector3 c = points.Max(pq.GetDistanceToPoint);
    
    hull.Insert(hull.IndexOf(q), c);

    FindHull(points.FindAll((new Segment(p, c)).GetSide), p, c);
    FindHull(points.FindAll((new Segment(c, q)).GetSide), c, q);
  }

}
