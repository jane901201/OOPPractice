public class ChapterList
{
    Chapter[] chapter;
}

public class Chapter
{
    private ConverationList converationList;
    public ConverationList ConverationList { get => converationList; set => converationList = value; }
}

public class ConverationList
{
    private Converation[] converation;

    public Converation[] Converation { get => converation; set => converation = value; }
}

public class Converation
{
    private string m_Topic;
    private SentenceList sentenceList;

    public string Topic { get => m_Topic; set => m_Topic = value; }
    public SentenceList SentenceList { get => sentenceList; set => sentenceList = value; }
}

public class SentenceList
{
    private Sentence[] sentence;
    public Sentence[] Sentence { get => sentence; set => sentence = value; }
}

public class Sentence
{
    private string m_CharacterName;
    private string m_AvatarName;


    public string Name { get => m_CharacterName; set => m_CharacterName = value; }
    public string AvatarString { get => m_AvatarName; set => m_AvatarName = value; }

}



