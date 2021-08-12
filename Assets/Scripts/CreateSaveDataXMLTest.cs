using System.Collections;
using UnityEngine;
using Unreal.AssetResources;
using UnityEngine.UI;
using Unreal.UI;


public class CreateSaveDataXMLTest : MonoBehaviour
{
    private IResources m_Resources = new ProjectResources();
    private SaveDataFileDataBase m_SaveDataFileDataBase = null;
    private SaveDataFileDataBase saveDataFileDataBase2 = null;

    [SerializeField] private Button m_CreateSaveDataXMLBtn;
    [SerializeField] private Button m_LoadSaveDataXMLBtn;
    //[SerializeField] private SaveDataUI m_SaveDataUI;

    // Use this for initialization
    void Start()
    {
        m_SaveDataFileDataBase = new SaveDataFileDataBase();

        m_LoadSaveDataXMLBtn.onClick.AddListener( delegate()
        {
            saveDataFileDataBase2 =  m_Resources.LoadSaveDataFileDataBaseXML();
        }
            ); //TODO:只是測試功能是否正常
        m_CreateSaveDataXMLBtn.onClick.AddListener(() => m_Resources.SaveSaveDataFileDataBase(m_SaveDataFileDataBase));

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(saveDataFileDataBase2);
    }
}
