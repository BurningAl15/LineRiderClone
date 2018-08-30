using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreator : MonoBehaviour {

    public List<GameObject> linePrefabs;
    public GameObject current;
    Line activeLine;

    private void Start()
    {
        current = linePrefabs[0];
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            GameObject lineGO= Instantiate(current);
            activeLine = lineGO.GetComponent<Line>();
            activeLine.gameObject.AddComponent<LineDestroyer>();
        }

        if(Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }

        if (activeLine != null)
        {
            //Remember that Input.mousePosition is in screen coordinates
            //To work with them we must convert them to world coordinates
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousePos);
        }
	}

    public void CurrentLine(int line)
    {
        switch(line)
        {
            case 0:
                current = linePrefabs[0];
            break;
            case 1:
                current = linePrefabs[1];
            break;
            case 2:
                current = linePrefabs[2];
            break;
            case 3:
                current = linePrefabs[3];
            break;
        }
    }

}
