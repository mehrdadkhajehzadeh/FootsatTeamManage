using FootsalTeamManage.Entity;

namespace FootsalTeamManage.Service.Teams.Contract.Dtos
{
    public class AddTeamDto
    {
        public string TeamName { get; set; }
        public ClothesColor FirstClotheColor { get; set; }
        public ClothesColor SecondClotheColor { get; set; }
    }
}
