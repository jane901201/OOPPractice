using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Unreal.UI
{
    public class DataCheckInfoUI : IUserInterface
    {
        [SerializeField] private GameObject m_DataChekcInfoUIObj;
        [SerializeField] private Text m_AlertText;
        [SerializeField] private Button m_YesButton;
        [SerializeField] private Button m_NoButton;

        private bool m_IsAnswer = false;

        public override void Initialize()
        {
            SetYesBtn();
            SetNoBtn();
        }

        public void SetDataCheckInfoUIIsActive()
        {
            m_DataChekcInfoUIObj.SetActive(true);
        }

        public void SetDataCheckInfoUIIsNotActive()
        {
            m_DataChekcInfoUIObj.SetActive(false);
        }

        public void ShowSaveDataIsNotFoundAlert()
        {
            m_AlertText.text = "還沒有存檔";
        }

        public void ShowWantToLoadDavaAlert()
        {
            m_AlertText.text = "是否要讀取這個檔案?";
        }

        public bool IsCheck()
        {
            Debug.Log(m_IsAnswer);
            return m_IsAnswer;
        } 

        private void SetYesBtn()
        {
            m_YesButton.onClick.AddListener(() => m_IsAnswer = true);
        }

        private void SetNoBtn()
        {
            m_NoButton.onClick.AddListener(() => m_IsAnswer = false);
        }

      



    }
}