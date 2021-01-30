using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace TerraFirma.UI
{
    public class UIMap : MonoBehaviour
    {
        [SerializeField] private GameObject mapView;
        [SerializeField] private UIMapIndicator playerLocationIndicator;
        [SerializeField] private UIMapIndicator targetLocationIndicator;
        [SerializeField] private GameObject linePrefab;
        private List<GameObject> lines;
        [SerializeField] private MapRoute currentRoute;
        [SerializeField] private MapRoute drawnRoute;

        private int initialTimeForNextIsland = -1;
        [SerializeField] private int timeToNextIsland = -1;

        private bool travelling;

        private void Start()
        {
            currentRoute = null;
            drawnRoute = null;
            travelling = false;
            lines = new List<GameObject>();
            playerLocationIndicator.SetLocation(new Vector3(0, 0, 0));
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.M)) ToggleMap();
            if (Input.GetKeyDown(KeyCode.N)) ChooseRoute();

            if (currentRoute != null && !mapView.activeSelf) travelling = true;
            else travelling = false;

            if (timeToNextIsland > 0 && travelling) timeToNextIsland--;
            else if (timeToNextIsland == 0) RouteFinished();
        }

        private void RouteFinished()
        {
            currentRoute = null; //This here makes travelling set to false
        }

        private void ChooseRoute()
        {
            if (drawnRoute == null) return;
            currentRoute = drawnRoute;
            timeToNextIsland = (int)currentRoute.TotalTravelTime();
            initialTimeForNextIsland = timeToNextIsland;
        }

        public void SetTargetIndicatorLocation(BaseEventData data)
        {
            PointerEventData pData = data as PointerEventData;
            float borders = 20;
            Vector3 newLocation = new Vector3(pData.pressPosition.x - borders, pData.pressPosition.y - borders, 0);
            targetLocationIndicator.SetLocation(newLocation);

            drawnRoute = new MapRoute();
            Vector3 playerLoc = playerLocationIndicator.GetComponent<RectTransform>().localPosition;
            drawnRoute.StartPosition = playerLoc;
            drawnRoute.TargetPosition = newLocation;

            ClearLines();
            DrawLine(playerLoc, newLocation);
        }

        private void ClearLines()
        {
            foreach (GameObject go in lines)
            {
                GameObject.Destroy(go);
            }
            lines = new List<GameObject>();
        }

        private void DrawLine(Vector2 pointA, Vector2 pointB)
        {
            float lineWidth = 2;

            Vector3 differenceVector = pointB - pointA;
            GameObject line = Instantiate(linePrefab, mapView.transform);
            RectTransform imageRectTransform = line.GetComponent<RectTransform>();
            imageRectTransform.sizeDelta = new Vector2(differenceVector.magnitude, lineWidth);
            imageRectTransform.pivot = new Vector2(0f, 0f);
            imageRectTransform.localPosition = new Vector3(pointA.x, pointA.y, 0);
            float angle = Mathf.Atan2(differenceVector.y, differenceVector.x) * Mathf.Rad2Deg;
            line.transform.localRotation = Quaternion.Euler(0, 0, angle);
            lines.Add(line);
        }

        public void ToggleMap()
        {
            mapView.SetActive(!mapView.activeSelf);
        }
    }

}
