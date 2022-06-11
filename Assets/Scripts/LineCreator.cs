using Assets.Scripts;
using UnityEngine;

public class LineCreator : MonoBehaviour
{
    public GameObject[] LinePrefabs;

    private Line _activeLine;

    // Update is called once per frame
    public void Update()
    {
        if(GameManager.Instance.IsGameRunning() is false)
        {
            return;
        }

        if (Input.GetMouseButtonDown(MouseButtonCodes.LeftMouseButton))
        {
            SetActiveLineToBoost();
        }

        if (Input.GetMouseButtonUp(MouseButtonCodes.LeftMouseButton))
        {
            _activeLine = null;
        }

        if (_activeLine == null)
        {
            return;
        }
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _activeLine.UpdateLine(mousePos);
    }

    // Unused for now
    //private void SetActiveLineToNormal()
    //{
    //    var lineGameObject = Instantiate(LinePrefabs[LinePrefabIndexes.LineNormalPrefab]);
    //    _activeLine = lineGameObject.GetComponent<Line>();
    //}
    private void SetActiveLineToBoost()
    {
        var lineGameObject = Instantiate(LinePrefabs[LinePrefabIndexes.LineBoostPrefab]);
        _activeLine = lineGameObject.GetComponent<Line>();
    }

    private static class MouseButtonCodes
    {
        public static int LeftMouseButton => 0;
        public static int RightMouseButton => 1;
    }

    private static class LinePrefabIndexes
    {
        public static int LineNormalPrefab => 0;
        public static int LineBoostPrefab => 1;
    }
}