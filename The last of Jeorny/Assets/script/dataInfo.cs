using System.Collections.Generic;




namespace DataInfo
{
    [System.Serializable]
    public class userData
    {
        public int level = 0;
        public float HP = 100.0f;
        public List<Heart> animalsHearts = new List<Heart>();
        public List<item> itemList = new List<item>();
    }


    [System.Serializable]
    public class Heart
    {
        public int crystal1 = 0;
        public int crystal2 =0;
        public int crystal3 =0;
        public int crystal4 =0;
        public int crystal7 =0;
        public int crystal8 =0;
        public int crystal10 =0;
    }

    [System.Serializable]
    public class item
    {
        public int star=0;
        public int stone=0;
        public int sheild=0;
        public int potion=0;
    }
}
