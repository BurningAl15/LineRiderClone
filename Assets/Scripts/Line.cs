using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {

    public LineRenderer line;
    public EdgeCollider2D edgeCol;

    List<Vector2> points;

    public float minDistance;

    public void UpdateLine(Vector2 mousePosition)
    {
        //If the list is empty, then create a new point in the list
        //With the position of the mousePosition
        if(points==null)
        {
            points = new List<Vector2>();
            SetPoint(mousePosition);
            return;
        }
        //Check if the mouse has moved enough for us to insert new point
        //If it has: Insert point at mouse position
        //points[points.Count-1]= points.Last()
        if (Vector2.Distance(points.Last(),mousePosition) > minDistance)
        {
            SetPoint(mousePosition);
        }
    }

    void SetPoint(Vector2 point)
    {
        points.Add(point);
        //Setting the number of positions in the line
        line.positionCount = points.Count;
        //Setting new index and points to the line
        line.SetPosition(points.Count - 1,point);
        //Setting the points of edge collider
        if(points.Count>1)
            edgeCol.points = points.ToArray();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
