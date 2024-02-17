namespace FootsalTeamManage.Entity
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public ClothesColor FirstClotheColor { get; set; }
        public ClothesColor SecondClotheColor { get; set; }


    }
    public enum ClothesColor
    {
        Red = 1 ,
        white,
        yellow,
        blue
    }
}
