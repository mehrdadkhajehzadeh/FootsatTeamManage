using FootsalTeamManage.Entity;

namespace FootsalTeamManage.Service.Teams.Contract.Dtos
{
    public class GetAllTeamDto
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public ClothesColor FirstClotheColor { get; set; }
        public ClothesColor SecondClotheColor { get; set; }
    }
}
