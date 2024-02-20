using UnityEngine;

public class Labirint : MonoBehaviour, Inilization, Restart, ICreatable
{
    [SerializeField] private LabirintData dataLabirint;

    private GameObject instantiatedLabirint; // ��������� �������� ���������

    public void Inilization( )
    {
        InitializeLabirint ( dataLabirint );
    }

    public void Restart( )
    {
        if ( instantiatedLabirint != null )
        {
            instantiatedLabirint.SetActive ( false ); // ������������ ������� ��������
        }

        InitializeLabirint ( dataLabirint ); // ������� ����� �������� ������ ���� ��� ���
    }

    public void StartGame( )
    {
        // ������ ������ ����
    }

    private void InitializeLabirint( LabirintData labirintData )
    {
        // ������������� ��������� �� ������ ������ �� LabirintData
        if ( labirintData != null && labirintData.LabirintPrefab != null )
        {
            instantiatedLabirint = Instantiate ( labirintData.LabirintPrefab , transform.position , Quaternion.identity );
            // �� ������ ����� ��������� ������ ��������� ���������, ����� ��� ���, �������� � �. �.
        }
        else
        {
            Debug.LogWarning ( "LabirintData ��� LabirintPrefab �� ����������� � ������� Labirint" );
        }
    }
}
