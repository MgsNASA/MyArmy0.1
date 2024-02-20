using System.Collections.Generic;
using UnityEngine;

public class LabirintManager : MonoBehaviour, Inilization, Restart, ICreatable
{
    [SerializeField] private int countLabirint;
    [SerializeField] private List<Labirint> labirintForLevel1 = new List<Labirint> ();
    [SerializeField] private List<Labirint> labirintForLevel2 = new List<Labirint> ();
    [SerializeField] private List<Labirint> labirintForLevel3 = new List<Labirint> ();

    private float zOffset = 0f; // ���������� ����� ����������� �� ��� Z

    public void Inilization( )
    {
        CreateLabirint ( countLabirint,labirintForLevel1 );
    }

    public void Restart( )
    {
        // ������ ����������� LabirintManager
        zOffset = 0f; // ������� �������� ��� �����������
    }

    public void StartGame( )
    {
        // ������ ������ ���� � LabirintManager
    }

    private void CreateLabirint( int numberLabirint,List<Labirint> labirints )
    {
        for (int i=0;i< labirints.Count; i++ )
        {

            Labirint labirint = labirints [ numberLabirint ];
            labirint.Inilization ();
            labirint.transform.position = new Vector3 ( transform.position.x , transform.position.y , transform.position.z + zOffset );
            zOffset += 10f; // ����������� �������� ��� ���������� ���������           
        }
    }

}
