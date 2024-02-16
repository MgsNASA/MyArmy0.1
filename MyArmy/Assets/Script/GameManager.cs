
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameManager : MonoBehaviour, Restart, Inilization,ICreatable
{
    [SerializeField] private GameObject [ ] _scriptObjects;
    public void Inilization( )
    {
       
    }

    public void Restart( )
    {
       
    }

    public void StartGame( )
    {
        foreach ( GameObject scriptObjectPrefab in _scriptObjects )
        {
            // ������� ��������� �������, � �������� ���������� ��������� �������
            GameObject newGameObject = Instantiate ( scriptObjectPrefab , Vector3.zero , Quaternion.identity );

            // �������� ��������� �������, �������������� � ���������� �������
            Inilization initializationComponent = newGameObject.GetComponent<Inilization> ();

            if ( initializationComponent != null )
            {
                // �������� ����� Initialize() ����� ���������
                initializationComponent.Inilization ();
            }
            else
            {
                Debug.LogWarning ( "���������, ����������� IInitialization, �� ������ �� ������� " + scriptObjectPrefab.name );
            }
        }
    }
}
