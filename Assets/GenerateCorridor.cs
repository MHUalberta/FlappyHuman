using UnityEngine;

public class GenerateCorridor : MonoBehaviour
{
    public GameObject corridorSegmentPrefab;
    public int numSegments = 5;
    public float segmentLength;

    void Start()
    {
        segmentLength = corridorSegmentPrefab.transform.localScale.x    ;
        for (int i = 0; i < numSegments; i++)
        {
            Vector3 position = new Vector3(i * (segmentLength * 10), 0, 0);
            GameObject cor = Instantiate(corridorSegmentPrefab, position, Quaternion.identity);
            cor.transform.position = position;
            Debug.Log(i);
        }
    }
}