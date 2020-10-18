using System.Collections.Generic;




namespace DataInfo
{
    [System.Serializable]

    public class userData
    {
        //레벨
        //체력
        //동물과의 관계-list
        //아이템-list

        public int level = 0;
        public float HP = 100.0f;
        public List<Heart> animalsHearts = new List<Heart>();
        public List<item> itemList = new List<item>();

    }


    [System.Serializable]
    public class Heart
    { }

    [System.Serializable]
    public class item
    { }
}
