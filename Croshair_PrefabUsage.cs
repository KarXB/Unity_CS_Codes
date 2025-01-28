using UnityEngine;

public class CrosshairPrefabUsage : MonoBehaviour
{
    public GameObject crosshairPrefab;
    private GameObject crosshairInstance;

    void Start()
    {
        crosshairInstance = Instantiate(crosshairPrefab);
        crosshairInstance.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
    }

    void Update()
    {
        if (crosshairInstance != null)
        {
            crosshairInstance.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        }
    }
}