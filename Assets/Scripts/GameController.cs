using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

  public Transform pointPrefab;
  public Grid grid;

  private Distribution2D distribution;

  void Start()
  {
    distribution = new Distribution2D(grid);
  }

  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      UpdateDistribution();
    }
  }

  void UpdateDistribution()
  {
    GameObject[] points = GameObject.FindGameObjectsWithTag("Point");
    for (int i = 0; i < points.Length; i++)
    {
      Destroy(points[i]);
    }
    distribution.Generate();
    foreach (Vector3 point in distribution.points)
    {
      Instantiate(pointPrefab, point, Quaternion.identity);
    }
  }
}
