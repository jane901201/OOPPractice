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
        private bool m_HaveData = false;

        public override void Initialize()
        {
            HideDataCheckInfoUI();
        }

        public void ShowDataCheckInfoUI()
        {
            m_DataChekcInfoUIObj.SetActive(true);
        }

        public void HideDataCheckInfoUI()
        {
            m_DataChekcInfoUIObj.SetActive(false);
        }

        public void ShowSaveDataIsNotFoundAlert()
        {
            m_YesButton.gameObject.SetActive(true);
            m_NoButton.gameObject.SetActive(false);
            m_AlertText.text = "還沒有存檔";
            m_YesButton.onClick.AddListener(() => HideDataCheckInfoBtn());
        }

        private void HideDataCheckInfoBtn()
        {
                HideDataCheckInfoUI();
                RefreshView();
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

        private void SetYesBtnIsTrue()
        {
            m_YesButton.onClick.AddListener(delegate()
            {
                m_IsAnswer = true;
                //TODO:呼叫SaveDataManager去Load檔案
                HideDataCheckInfoBtn();
            });
        }

        private void SetNoBtnIsFalse()
        {
            m_NoButton.onClick.AddListener(delegate()
            {
                m_IsAnswer = false;
                HideDataCheckInfoBtn();
            });
        }

      
        private void RefreshView()
        {
            m_YesButton.gameObject.SetActive(true);
            m_NoButton.gameObject.SetActive(true);
        }


    }
}