using FootsalTeamManage.Entity;

namespace FootsalTeamManage.Service.Teams.Contract.Dtos
{
    public class UpdateTeamDto
    {
        public string TeamName { get; set; }
        public ClothesColor FirstClotheColor { get; set; }
        public ClothesColor SecondClotheColor { get; set; }
    }
}
