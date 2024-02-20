using UnityEngine;

[CreateAssetMenu ( fileName = "NewLabirintData" , menuName = "Labirint Data" , order = 51 )]
public class LabirintData : ScriptableObject
{
    [SerializeField] private GameObject labirintPrefab;
    [SerializeField] private string labirintName;
    [SerializeField] private string labirintDescription;
    [SerializeField] private int labirintIndex;
    [SerializeField] private GameObject enemy;


    public GameObject LabirintPrefab => labirintPrefab;
    public string LabirintName => labirintName;
    public string LabirintDescription => labirintDescription;
    public int LabirintIndex => labirintIndex;
}