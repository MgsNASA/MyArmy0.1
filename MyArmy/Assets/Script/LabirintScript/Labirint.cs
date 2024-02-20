using UnityEngine;

public class Labirint : MonoBehaviour, Inilization, Restart, ICreatable
{
    [SerializeField] private LabirintData dataLabirint;

    private GameObject instantiatedLabirint; // Ёкземпл€р текущего лабиринта

    public void Inilization( )
    {
        InitializeLabirint ( dataLabirint );
    }

    public void Restart( )
    {
        if ( instantiatedLabirint != null )
        {
            instantiatedLabirint.SetActive ( false ); // ƒеактивируем текущий лабиринт
        }

        InitializeLabirint ( dataLabirint ); // —оздаем новый лабиринт только если его нет
    }

    public void StartGame( )
    {
        // Ћогика начала игры
    }

    private void InitializeLabirint( LabirintData labirintData )
    {
        // »нициализаци€ лабиринта на основе данных из LabirintData
        if ( labirintData != null && labirintData.LabirintPrefab != null )
        {
            instantiatedLabirint = Instantiate ( labirintData.LabirintPrefab , transform.position , Quaternion.identity );
            // ¬ы можете также настроить другие параметры лабиринта, такие как им€, описание и т. д.
        }
        else
        {
            Debug.LogWarning ( "LabirintData или LabirintPrefab не установлены в объекте Labirint" );
        }
    }
}
