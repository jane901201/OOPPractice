using System.Collections;
using UnityEngine;

namespace Unreal
{
    public class GameLoop : MonoBehaviour
    {
        UnrealGame m_UnrealGame = new UnrealGame();

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
            m_UnrealGame.Awake();
        }

        private void Start()
        {
            m_UnrealGame.SetMainMenuScene();
            m_UnrealGame.SetUI("MainMenuUI");
            m_UnrealGame.SceneUpdate();
          
        }

        private void Update()
        {
            
        }

        private void GameObjectInstantiate(GameObject UI)
        {
            Instantiate(UI, new Vector3(0f, 0f), Quaternion.identity).SetActive(true);

        }

    }

}