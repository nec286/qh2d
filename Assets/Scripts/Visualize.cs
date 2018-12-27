using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visualize : MonoBehaviour {

  public int x, y, w, h;

  private LineRenderer lineRenderer;
  private Seeder seeder;
  private QuickHull quickHull = new QuickHull();

  void Start() {
    lineRenderer = GetComponent<LineRenderer>();
    seeder = new Seeder(x, y, w, h);
  }

  void Update() {
    if (Input.GetMouseButtonDown(0)) {
      List<Vector3> points = quickHull.FindHull(seeder.Generate());

      lineRenderer.positionCount = points.Count;
      lineRenderer.SetPositions(points.ToArray());
    }
  }
  
}