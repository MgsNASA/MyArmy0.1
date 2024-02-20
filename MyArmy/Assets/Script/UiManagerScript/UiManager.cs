using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
public class UIManager : MonoBehaviour, Inilization, Restart
{
    public enum UIState
    {
        MainMenu,
        Settings,
        Shop,
        GameHud,
        EndGamePanel
        // �������� ������ ��������� �� ���� �������������
    }
    public GameObject mainMenuUI;
    public GameObject settingsUI;
    public GameObject shopUI;
    public GameObject gameHud;
    // �������� ������ ������� UI �� ���� �������������

    private UIState currentState = UIState.MainMenu;

    // ������� ����������� ������ �� ��������� ������
    private static UIManager _instance;
    public static UIManager Instance => _instance;

    private void Awake( )
    {
        // ���������, ���������� �� ��� ���������
        if ( _instance != null && _instance != this )
        {
            // ���������� ������� ���������, ���� �� �� ��������� � ���� ��������
            Destroy ( this.gameObject );
        }
        else
        {
            // ������������� ���� ��������� ��� ��������
            _instance = this;
        }
    }

    public void Inilization( )
    {
        SwitchUIState ( UIState.MainMenu );
    }

    private void SwitchUIState( UIState newState )
    {
        // ��������� ��� UI ����
        mainMenuUI.SetActive ( false );
        settingsUI.SetActive ( false );
        shopUI.SetActive ( false );
        gameHud.SetActive ( false );
       

        // �������� UI ���� � ������������ � ����� ����������
        switch ( newState )
        {
            case UIState.MainMenu:
                mainMenuUI.SetActive ( true );
                break;

            case UIState.Settings:
                settingsUI.SetActive ( true );
                break;

            case UIState.Shop:
                shopUI.SetActive ( true );
                break;

            case UIState.GameHud:
                gameHud.SetActive ( true );
                break;

      

                // ���������� ������ ������ �� ���� ���������� ���������
        }

        // ��������� ������� ���������
        currentState = newState;
    }

    public void SetUIStateMainMenu( )
    {
        SwitchUIState ( UIState.MainMenu );
    }

    public void SetUIStateSettings( )
    {
        SwitchUIState ( UIState.Settings );
    }

    public void SetUIStateShop( )
    {
        SwitchUIState ( UIState.Shop );
    }

    public void SetUIStateGameHud( )
    {
        SwitchUIState ( UIState.GameHud );
    }

    public void SetUIStateEndGamePanel( bool stateEnd )
    {
        SwitchUIState ( UIState.EndGamePanel );
        //endGamePanel.EndGameTextChange ( stateEnd );
    }

    public void StartGame( )
    {
        // ���������� ��� ������ ����, �������� ��� UI ����
        mainMenuUI.SetActive ( false );
        settingsUI.SetActive ( false );
        shopUI.SetActive ( false );
        gameHud.SetActive ( true ); // ���������� GameHud ��� ������ ����
        // �������� ������ ��������, ������� ���������� ��� ������ ����
    }

    public void Restart( )
    {
        // �������� ��� ��� ������ ��������� UI � �������� � ��������� ���������
        // ������: ������������� � ������� ����
        SwitchUIState ( UIState.MainMenu );
        // ������������� �������� ����� ������ ����������, ���� ��� ����������
    }

    // �������� ������ ������ ��� ��������� ��������� �� ���� �������������
}
