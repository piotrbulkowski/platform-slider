using UnityEngine;

public class LineCreator : MonoBehaviour
{
    public GameObject[] linePrefabs;

    LineCreator listLines;
    Line activeLine;

    private const int LeftMouseButtonCode = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouseButtonCode))
        {
            int index = ChangeLine();
            GameObject lineGO = Instantiate(linePrefabs[index]);
            activeLine = lineGO.GetComponent<Line>();
        }

        if (Input.GetMouseButtonUp(LeftMouseButtonCode))
        {
            activeLine = null;
        }

        if (activeLine != null)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousePos);
        }
    }

    int ChangeLine()
    {
        int index = Random.Range(0, 3);
        return index;
    }
}