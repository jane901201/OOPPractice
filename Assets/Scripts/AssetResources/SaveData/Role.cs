namespace Unreal.AssetResources
{
    public class Role
    {
        private int m_Hp = 0; //生命條
        private int m_Mp = 0; //魔力條
        private int m_Str = 0; //力量
        private int m_Def = 0; //防禦
        private int m_Mag = 0; //魔力
        private int m_MoveSpd = 0; //移動速度
        private int m_AtkSpd = 0; //攻擊速度
        private int m_Res = 0; //魔法抵抗

        public int Hp { get => m_Hp; set => m_Hp = value; }
        public int Mp { get => m_Mp; set => m_Mp = value; }
        public int Str { get => m_Str; set => m_Str = value; }
        public int Def { get => m_Def; set => m_Def = value; }
        public int Mag { get => m_Mag; set => m_Mag = value; }
        public int MoveSpd { get => m_MoveSpd; set => m_MoveSpd = value; }
        public int AtkSpd { get => m_AtkSpd; set => m_AtkSpd = value; }
        public int Res { get => m_Res; set => m_Res = value; }
    }
}