using System.IO;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Localization;
using Unreal.Dialogue;

/// <summary>
/// Ū������
/// TODO:Ū�ɸ�s�ɪ��Ыظ��|?�n�A�Q�Q
/// </summary>

namespace Unreal.AssetResources
{
    public class ProjectResources : IResources
    {

        private const string PlayerPath = "Characters/Player/";
        private const string EnemyPath = "Characters/Enemy/";
        private const string CharacterAvatarTestPath = "CharacterAvatar/CharacterAvatarTest";
        private const string UIPath = "UI/";
        private const string WeaponPath = "Weapons/";
        private const string EffectPath = "Effects/";
        private const string AudioPath = "Audios/";
        private const string SpritePath = "Sprites/";
        private const string SaveDataPath = "SaveData/";


        public override AudioClip LoadAudioClip(string AudioClipName)
        {
            AudioClip res = Resources.Load<AudioClip>(AudioPath + AudioClipName);
            if (res == null)
                return null;
            return res;
        }

        public override GameObject LoadPlayer(string PlayerName)
        {
            UnityEngine.Object res = LoadGameObjectFromResourcePath(PlayerPath + PlayerName);
            if (res == null)
                return null;
            return res as GameObject;
        }


        public override Sprite LoadCharacterAvatar(string CharacterAvatarName)
        {
            Sprite res = Resources.Load<Sprite>(SpritePath + CharacterAvatarName);

            if (res == null)
            {
                Debug.Log("�L�k���J���|" + SpritePath + CharacterAvatarName);
                return null;
            }
            return res;
        }
        public override void LoadEffect(string EffectName)
        {
            UnityEngine.Object res = LoadGameObjectFromResourcePath(EffectPath + EffectName);
        }

        public override GameObject LoadUI(string UIName)
        {
            UnityEngine.Object res = LoadGameObjectFromResourcePath(UIPath + UIName);
            if (res == null)
                return null;
            return res as GameObject;
        }

        public override Sprite LoadSprite(string SpriteName)
        {
            //Sprite res = Resources.Load<Sprite>(SpritePath + SpriteName);
            Sprite res = Resources.Load<Sprite>(SpritePath + SpriteName);

            if (res == null)
            {
                Debug.Log("�L�k���J���|" + SpritePath + SpriteName);
                return null;
            }
            return res;
        }

        public override GameObject LoadWeapon(string WeaponName)
        {
            UnityEngine.Object res = LoadGameObjectFromResourcePath(SpritePath + WeaponName);
            if (res == null)
                return null;
            return res as GameObject;
        }

   

        // �qResrouce�����J
        public UnityEngine.Object LoadGameObjectFromResourcePath(string AssetPath)
        {
            UnityEngine.Object res = Resources.Load(AssetPath);
            if (res == null)
            {
                Debug.LogWarning("�L�k���J���|[" + AssetPath + "]�W��Asset");
                return null;
            }
            return res;
        }

        public override TextAsset LoadStoryTable(string Table, string Entry)
        {
            LocalizedTextAsset localizedTextAsset = new LocalizedTextAsset();
            localizedTextAsset.SetReference(Table, Entry);
            TextAsset res = localizedTextAsset.LoadAsset();
            if (res == null)
                return null;
            return res;
        }

        public override TextAsset LoadXML(string SaveDataName) //TODO:�������ӷ|�]private�A�ΰ��ܥΨ�LoadXML
        {
            TextAsset res = Resources.Load<TextAsset>(SaveDataPath + SaveDataName);
            if (res == null)
                return null;
            return res;
        }



        public override string[] LoadConveration(int chapter, int converation)
        {
            ConverationData converationData = new ConverationData();

            string[][] converationDataFile = converationData.GetConveration();
            string currectChapter = "Chapter" + chapter.ToString();
            string currectConveration = converationDataFile[chapter][converation];

            string[] tmpConveration = new string[2];

            tmpConveration[0] = currectChapter;
            tmpConveration[1] = currectConveration;

            return tmpConveration;

        }

        public override TextAsset LoadConverationTextAssetInk(int chapter, int converation)
        {
            string[] TestChapterString = LoadConveration(chapter, converation);
            TextAsset testTextAsset = LoadStoryTable(TestChapterString[0], TestChapterString[1]);

            return testTextAsset;
        }

        public override SaveDataFileDataBase LoadSaveDataFileDataBaseXML()
        {
            TextAsset saveData = LoadXML("SaveDataFile");

            XmlSerializer serializer = new XmlSerializer(typeof(SaveDataFileDataBase));
            using (StringReader reader = new StringReader(saveData.text))
            {
                return serializer.Deserialize(reader) as SaveDataFileDataBase;
            }
        }

        public override void SaveSaveDataFileDataBase(SaveDataFileDataBase saveData)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SaveDataFileDataBase));
            FileStream stream = new FileStream(Application.dataPath + "/Resources/SaveData/SaveDataFile.xml", FileMode.Create);
            serializer.Serialize(stream, saveData);
            stream.Close();
        }
    }

}
