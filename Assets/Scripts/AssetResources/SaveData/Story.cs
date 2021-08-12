namespace Unreal.AssetResources
{
    public class Story
    {
        private int m_chapter = 0;
        private int m_Conversation = 0; //TODO:對話進度...不過未來應該是用定點式觸發...

        public int Chapter { get => m_chapter; set => m_chapter = value; }
        public int Conversation { get => m_Conversation; set => m_Conversation = value; }
    }
}