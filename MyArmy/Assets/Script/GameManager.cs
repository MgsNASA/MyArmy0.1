
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameManager : MonoBehaviour, Restart, Inilization,ICreatable
{
    [SerializeField] private GameObject [ ] _scriptObject;
    public void Inilization( )
    {
        //_scriptObject[0].In
    }

    public void Restart( )
    {
       
    }

    public void StartGame( )
    {
       
    }
}
